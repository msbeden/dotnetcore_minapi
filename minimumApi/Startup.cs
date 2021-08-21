using AutoMapper;
using minimumApi.Configuration;
using minimumApi.Configuration.Authorization;
using minimumApi.Configuration.MapperProfiles;
using minimumApi.Configuration.MapperProfiles.ApplicantInfo;
using minimumApi.Models;
using minimumApi.Repositories;
using minimumApi.Repositories.Abstractions;
using minimumApi.Repositories.Services.Abstractions;
using minimumApi.Services;
using minimumApi.Services.Abstractions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace minimumApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Authentication eklemesi
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer();

            //Veritabaný eklemesi
            string connectionString = Configuration.GetConnectionString("default");
            services.AddDbContext<minimumApiDbContext>(options => options.UseSqlServer(connectionString));
            DBInitializer.Initialize(connectionString);

            //Cors eklemesi
            services.AddCors();

            services.AddSwaggerGen(c =>
            {
                //Sað Üst Köþe Dokümantasyon Eklemeleri
                c.SwaggerDoc("Authentication", new OpenApiInfo { Title = "Eyaz.minimumApi - Authentication", Version = "v1" });
                c.SwaggerDoc("GenericControllers", new OpenApiInfo { Title = "Eyaz.minimumApi - Generic Tables", Version = "v1" });
                c.SwaggerDoc("StaticTables", new OpenApiInfo { Title = "Eyaz.minimumApi - Static Tables", Version = "v1" });
                c.SwaggerDoc("FirmRequest", new OpenApiInfo { Title = "Eyaz.minimumApi - Firm Request", Version = "v1" });
                c.SwaggerDoc("FirmInventory", new OpenApiInfo { Title = "Eyaz.minimumApi - Firm Inventory", Version = "v1" });
                c.SwaggerDoc("ApplicantInfo", new OpenApiInfo { Title = "Eyaz.minimumApi - Applicant Info", Version = "v1" });

                //Authentication eklemesi
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    Scheme = "Bearer",
                    BearerFormat = "Jwt",
                    Name = "Jwt Authentication",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Description = "Enter **_ONLY**_ your Jwt Bearer token on textbox below!",
                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };

                c.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement { { jwtSecurityScheme, Array.Empty<string>() } });
                //Authentication eklemesi
            });

            // Mapping
            var mappingConfig = new MapperConfiguration(mc =>
            {
                #region Generic Tables
                mc.AddProfile(new CountryMapper());
                mc.AddProfile(new TownMapper());
                mc.AddProfile(new CityMapper());
                mc.AddProfile(new AuthGroupMapper());
                mc.AddProfile(new AuthUserMapper());
                mc.AddProfile(new AuthFeatureMapper());
                mc.AddProfile(new AuthPermissionMapper());
                mc.AddProfile(new SignInMapper());
                #endregion


                #region Applicant Info
                mc.AddProfile(new ApplicantEducationMapper());
                mc.AddProfile(new ApplicantMapper());
                #endregion
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddSingleton(this.Configuration);
            services.AddSingleton<ITokenManagerService, TokenManagerService>();
            services.AddScoped(typeof(IRepository<>), typeof(GeneralRepository<>));
            services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));
            services.AddScoped(typeof(IGenericDefinitionsBaseService<,>), typeof(GenericDefinitionsBaseService<,>));
            services.AddScoped(typeof(IApplicantBaseService<,>), typeof(ApplicantBaseService<,>));
            services.AddScoped<AuthorizationFilter>();
            services.AddScoped<IAuthorizationFilterService, AuthorizationFilterService>();
            services.AddScoped<ISignInService, SignInService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ITownService, TownService>();
            // Mapping
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/Authentication/swagger.json", "minimumApi - Authentication");
                c.SwaggerEndpoint("/swagger/GenericControllers/swagger.json", "minimumApi - Generic Tables");
                c.SwaggerEndpoint("/swagger/StaticTables/swagger.json", "minimumApi - Static Tables");
                c.SwaggerEndpoint("/swagger/ApplicantInfo/swagger.json", "minimumApi - Applicant Info");
            });

            //Cors eklemesi
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            // app.UseHttpsRedirection();

            app.UseRouting();
            //Authentication eklemesi
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}