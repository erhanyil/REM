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
    [Table("tblusers")]
    public class GlobalUsersModel : TableLibrary
    {
        [Required, Key]
        public int userID { get; set; }
        public int userRoleID { get; set; }
        public int companyID { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userEmail { get; set; }
    }
}