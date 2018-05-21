using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using stdioCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace REM.Models
{
    [Table("tblAdverts")]
    public class AdvertModal
    {
        [Required, Key]
        [Display(Name ="İlan No")]
        public int advertID { get; set; }
        [Display(Name = "İlan Başlığı")]
        public string advertTitle { get; set; }
        [Display(Name = "İlan Detayı")]
        public string advertDetail { get; set; }
        [Display(Name = "İlan Tipi")]
        public int advertType { get; set; }
    }
}