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
    [Table("tblCompany")]
    public class GlobaCompanyModel : TableLibrary
    {
        [Required, Key]
        public int companyID { get; set; }
        public string companyName { get; set; }

        public bool IsInCompany(string _companyName)
        {
            return glblCompany.Where(u => u.companyName == _companyName).ToList().Count > 0 ? true : false;
        }
    }
}