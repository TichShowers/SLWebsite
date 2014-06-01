using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SLWebsite.DAL.Mappers;
using SLWebsite.Models;

namespace SLWebsite.DAL
{
    public class ProjectContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }

        public ProjectContext() : base("DefaultConnection")
        {
            System.Data.Entity.Database.SetInitializer(new ProjectInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RoleMapper());
        }
    }
}