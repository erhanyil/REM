using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stdioCore;
using System.Data.Entity;
using REM.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using REM.Controllers;

namespace REM.App_Start
{
    public class AuthConfig
    {

        public string _userEmail { get; set; }
        public string _password { get; set; }
        public string _companyName { get; set; }

        DatabaseLibrary dbl;
        SessionModel _session;

        public SessionModel loginAuthentication()
        {
            return checkCredentials();
        }

        protected SessionModel checkCredentials()
        {
            dbl = new DatabaseLibrary();
            if (_companyName != null && _userEmail != null && _password != null)
            {
                _session = new SessionModel();
                int companyID = dbl.tbl.glblCompany.Where(u => u.companyName == _companyName).Select(u => u.companyID).SingleOrDefault();
                List<GlobalUsersModel> list = dbl.tbl.glblUsers.Where(u => u.userEmail == _userEmail && u.userPassword == _password && u.companyID == companyID).ToList();
                if (list.Count == 1)
                {
                    int userRoleID = list[0].userRoleID;
                    string roleName = dbl.tbl.glblUserRoles.Where(u => u.userRoleID == userRoleID).Select(u => u.userRoleName).SingleOrDefault();

                    _session = new SessionModel()
                    {
                        _userInfo = list[0],
                        _roleName = roleName,
                        _companyName = _companyName
                    };
                }
            }
            return _session;
        }
    }
}