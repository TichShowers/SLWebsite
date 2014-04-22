using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Optimization;

namespace SLWebsite.Models
{
    public class Role
    {
        public int  Id { get; set; }
        public string InternalName { get; set; }
        public string Name { get; set; }
        public Role ChildRole { get; set; }

        public IList<Role> GetAllChildRoles()
        {
            if (ChildRole == null)
            {
                return new List<Role>();
            }
            var roles = ChildRole.GetAllChildRoles();
            roles.Add(ChildRole);
            return roles;
        }
    }
}