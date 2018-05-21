using System;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Dynamic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Reflection;

namespace stdioCore
{
    public class DatabaseLibrary
    {
        public TableLibrary tbl;

        public DatabaseLibrary(string _companyName) : base()
        {
            var settings = ConfigurationManager.ConnectionStrings[3];
            var fi = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
            fi.SetValue(settings, false);
            settings.ConnectionString = "Server=localhost;user id=root;password=;database=" + _companyName;
            tbl = new TableLibrary("REMLocalConnection");
        }
        public DatabaseLibrary() : base()
        {
            tbl = new TableLibrary("GlobalDatabaseConnection");
        }
    }
}
