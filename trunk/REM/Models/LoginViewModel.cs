using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using stdioCore;
using Microsoft.AspNet.Identity.EntityFramework;

namespace REM.Models
{
    public class LoginViewModel : GlobalUsersModel
    {
        public string t_companyName { get; set; }
    }
}