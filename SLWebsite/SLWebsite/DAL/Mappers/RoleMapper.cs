using System.Data.Entity.ModelConfiguration;
using SLWebsite.Models;

namespace SLWebsite.DAL.Mappers
{
    public class RoleMapper : EntityTypeConfiguration<Role>
    {
        public RoleMapper()
        {
            HasKey(x => x.Id);
            HasRequired(x => x.ChildRole);
        }
    }
}