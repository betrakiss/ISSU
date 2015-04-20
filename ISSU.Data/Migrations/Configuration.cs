using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.Migrations;

using ISSU.Models;

namespace ISSU.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ISSUContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ISSU.Data.ISSUContext";

            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ISSUContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            roleManager.Create(new IdentityRole("Student"));
            roleManager.Create(new IdentityRole("Admin"));
        }
    }
}
