﻿using Capstones.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Capstones.Startup))]
namespace Capstones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }
        private void createRolesandUsers()
            {
                ApplicationDbContext context = new ApplicationDbContext();

                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


                // In Startup iam creating first Admin Role and creating a default Admin User     
                if (!roleManager.RoleExists("Admin"))
                {

                    // first we create Admin rool    
                    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                    role.Name = "Admin";
                    roleManager.Create(role);

                    //Here we create a Admin super user who will maintain the website                   

                    var user = new ApplicationUser();
                    user.UserName = "SuperDave";
                    user.Email = "davidwilliams1102@yahoo.com";

                    string userPWD = "!3584Dwilliams";

                    var chkUser = UserManager.Create(user, userPWD);

                    //Add default User to Role Admin    
                    if (chkUser.Succeeded)
                    {
                        var result1 = UserManager.AddToRole(user.Id, "Admin");

                    }
                }

                // creating Creating tourist role     
                if (!roleManager.RoleExists("Tourist"))
                {
                    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                    role.Name = "Tourist";
                    roleManager.Create(role);

                }

                // creating Creating event maker role     
                if (!roleManager.RoleExists("Event Maker"))
                {
                    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                    role.Name = "Event Maker";
                    roleManager.Create(role);

                }
            }
    }
}
