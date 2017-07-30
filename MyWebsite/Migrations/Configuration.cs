namespace MyWebsite.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MyWebsite.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<MyWebsite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "MyWebsite.Models.ApplicationDbContext";
        }

        protected override void Seed(MyWebsite.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(u => u.UserName == "quyhuyen.vu@gmail.com")) {
                var user = new ApplicationUser() {
                    FirstName = "Huyen",
                    LastName = "Vu",
                    Email = "quyhuyen.vu@gmail.com",
                    UserName = "quyhuyen.vu@gmail.com"
                };
                
                userManager.Create(user, "password**");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole {Name = "Admin" });
                context.SaveChanges();

                userManager.AddToRole(user.Id, "Admin");
                userManager.AddClaim(user.Id, new Claim(ClaimTypes.GivenName, user.FirstName));
            }




            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
