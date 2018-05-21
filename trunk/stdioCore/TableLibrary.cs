using System.Data.Entity;

namespace stdioCore
{
    public class TableLibrary : DbContext
    {
        public TableLibrary(string _connName) : base(_connName) { }
        public TableLibrary() : base("GlobalDatabaseConnection") { }

        #region GLOBAL TABLES
        public DbSet<GlobalUsersModel> glblUsers { get; set; }
        public DbSet<GlobalUserRolesModel> glblUserRoles { get; set; }
        public DbSet<GlobaCompanyModel> glblCompany { get; set; }

        #endregion
    }
}
