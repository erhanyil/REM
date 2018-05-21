using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using stdioCore;
using REM.Models;
using System.Data.Entity;

namespace REM.Controllers
{
    public class TablesController : TableLibrary
    {
        public TablesController() : base("REMLocalConnection") { }

        public DbSet<AdvertModal> tblAdverts { get; set; }
    }
}