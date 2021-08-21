using minimumApi.Models.DatabaseModels;
using minimumApi.Models.DatabaseModels.ApplicantInfo;
using minimumApi.Models.DatabaseModels.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Models
{
    public class minimumApiDbContext : DbContext
    {
        private string _connectionString;

        public minimumApiDbContext([NotNull] DbContextOptions options) : base(options) { }

        public minimumApiDbContext(string connectionString)
        {
            this._connectionString = connectionString;
            this.Database.SetCommandTimeout(TimeSpan.FromMinutes(1));
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Town> Towns { get; set; }

        #region Authentication_UserTables
        public DbSet<AuthGroup> AuthGroups { get; set; }
        public DbSet<AuthUser> AuthUsers { get; set; }
        public DbSet<AuthFeature> AuthFeatures { get; set; }
        public DbSet<AuthPermission> AuthPermissions { get; set; }
        public DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; }
        public DbSet<AuthUserFeature> AuthUserFeatures { get; set; }
        public DbSet<AuthUserGroup> AuthUserGroups { get; set; }
        #endregion


        #region StaticTables
        // ApplicantInfo
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<ApplicantEducation> ApplicantEducations { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(this._connectionString);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
