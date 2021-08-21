using AutoMapper;
using minimumApi.Models;
using minimumApi.Models.DatabaseModels.Auth;
using minimumApi.Models.ViewModels;
using minimumApi.Models.ViewModels.Login;
using minimumApi.Repositories.Abstractions;
using minimumApi.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace minimumApi.Services
{
    public class SignInService : ISignInService
    {
        IRepository<AuthUserGroup> _authUserGroupsRepo;
        IRepository<AuthUser> _authUsersRepo;
        IRepository<AuthUserFeature> _authUserFeaturesRepo;
        ITokenManagerService _tokenManagerService;
        IMapper _mapper;
        public SignInService(ITokenManagerService tokenManagerService, IMapper mapper, IRepository<AuthUser> authUsersRepo, IRepository<AuthUserGroup> authUserGroupsRepo, IRepository<AuthUserFeature> authUserFeaturesRepo)
        {
            this._tokenManagerService = tokenManagerService;
            this._mapper = mapper;
            this._authUsersRepo = authUsersRepo;
            this._authUserFeaturesRepo = authUserFeaturesRepo;
            this._authUserGroupsRepo = authUserGroupsRepo;
        }

        public ServiceResponse<bool> ActionAssignUserGroup(AssignUserGroupRequestViewModel userObject)
        {
            AuthUser authUserResult = this._authUsersRepo.Table.FirstOrDefault(x => x.Username == userObject.Username && x.Password == userObject.Password);
            if (authUserResult == null) return new ServiceResponse<bool>() { ExceptionMessage = "Invalid Username or password", HasExceptionError = true, Count = 0, IsSuccessful = false };

            bool hasAnyGroup = this._authUserGroupsRepo.Table.Any(x => x.AuthUserId == authUserResult.AuthUserId);
            if (hasAnyGroup) return new ServiceResponse<bool> { ExceptionMessage = "User has already group assignment", HasExceptionError = true, Count = 0, IsSuccessful = false };
            if (userObject.GroupId != 3 && userObject.GroupId != 4) return new ServiceResponse<bool> { ExceptionMessage = "Unauthorized operation", HasExceptionError = true, Count = 0, IsSuccessful = false };

            long result = this._authUserGroupsRepo.Insert(new AuthUserGroup
            {
                AuthUserId = authUserResult.AuthUserId,
                AuthGroupId = userObject.GroupId
            });

            ServiceResponse<bool> response = new ServiceResponse<bool>(null)
            {
                Count = (int)result,
                Entity = result > 0,
                IsSuccessful = result > 0
            };
            return response;

        }

        public ServiceResponse<bool> ActionForgottenPassword(ForgottenPasswordViewModel authObject)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<SignInResponseViewModel> ActionSignIn(SignInRequestViewModel authObject)
        {
            IQueryable<AuthUserFeature> authUserFeaturesQuery = this._authUserFeaturesRepo.IncludeMany(x => x.Feature, x => x.User);
            IQueryable<AuthUserGroup> authUserGroupsQuery = this._authUserGroupsRepo.IncludeMany(x => x.Group, x => x.User);

            AuthUser authUserResult = this._authUsersRepo.Table.FirstOrDefault(x => x.Username == authObject.Username && x.Password == authObject.Password);
            if (authUserResult == null)
            {
                return new ServiceResponse<SignInResponseViewModel>() { ExceptionMessage = "Invalid Username or password", Count = 0, IsSuccessful = false };
            }

            List<AuthGroup> authGroupsResult = authUserGroupsQuery.Where(x => x.AuthUserId == authUserResult.AuthUserId).Select(x => x.Group).ToList();
            IEnumerable<AuthGroupViewModel> authGroupViewModels = this._mapper.Map<IEnumerable<AuthGroupViewModel>>(authGroupsResult);

            List<AuthFeature> authFeaturesResult = authUserFeaturesQuery.Where(x => x.AuthUserId == authUserResult.AuthUserId).Select(x => x.Feature).ToList();
            IEnumerable<AuthFeatureViewModel> authFeatureViewModels = this._mapper.Map<IEnumerable<AuthFeatureViewModel>>(authFeaturesResult);

            SignInResponseViewModel responseEntity = this._mapper.Map<SignInResponseViewModel>(authUserResult);
            string jwtToken = this._tokenManagerService.GenerateToken(authUserResult, authGroupsResult);
            responseEntity.Token = jwtToken;
            responseEntity.Groups = authGroupViewModels;
            responseEntity.Features = authFeatureViewModels;

            ServiceResponse<SignInResponseViewModel> response = new ServiceResponse<SignInResponseViewModel>(null)
            {
                Count = 1,
                Entity = responseEntity,
                IsSuccessful = true
            };

            return response;
        }

        public ServiceResponse<bool> ActionSignUp(SignUpViewModel userObject)
        {
            AuthUser newUser = this._mapper.Map<AuthUser>(userObject);
            newUser.PasswordHash = "*";
            int userId = (int)this._authUsersRepo.Insert(newUser);

            IList<AuthUserGroup> authUserGroups = new List<AuthUserGroup>();
            if (userObject.GroupIds != null)
            {
                foreach (int groupId in userObject.GroupIds)
                {
                    authUserGroups.Add(new AuthUserGroup
                    {
                        AuthGroupId = groupId,
                        AuthUserId = userId
                    });
                }
                this._authUserGroupsRepo.Insert(authUserGroups);
            }

            IList<AuthUserFeature> authUserFeatures = new List<AuthUserFeature>();
            if (userObject.Features != null)
            {
                foreach (KeyValuePair<int, int> feature in userObject.Features)
                {
                    authUserFeatures.Add(new AuthUserFeature
                    {
                        AuthFeatureId = feature.Key,
                        AuthFeatureValue = feature.Value,
                        AuthUserId = userId
                    });
                }
                this._authUserFeaturesRepo.Insert(authUserFeatures);
            }
            ServiceResponse<bool> response = new ServiceResponse<bool>(null);
            response.Count = 1;
            response.Entity = true;
            response.IsSuccessful = true;

            return response;
        }
    }
}
