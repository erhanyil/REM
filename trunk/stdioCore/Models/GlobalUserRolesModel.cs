using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Linq;
using System.Web;
using stdioCore;
using System.Data.Entity;

namespace stdioCore
{
    [Table("tblUserRoles")]
    public class GlobalUserRolesModel : TableLibrary
    {
        [Required, Key]
        public int userRoleID { get; set; }
        public string userRoleName { get; set; }
    }
}