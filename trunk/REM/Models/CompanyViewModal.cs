using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using stdioCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace REM.Models
{
    public class CompanyViewModal
    {
        [Required, Key]
        public int companyID { get; set; }
        public string companyName { get; set; }

    }
}