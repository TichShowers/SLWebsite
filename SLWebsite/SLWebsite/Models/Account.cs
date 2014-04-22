using System;
using System.Collections;
using System.Collections.Generic;

namespace SLWebsite.Models
{
    public class Account
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public bool Enabled { get; set; }
        public bool System { get; set; }
        public DateTime Created { get; set; }
        public virtual IList<Resource> List { get; set; }
        public virtual Role Role { get; set; }

        public IList<Role> GetAllRoles()
        {
            var roles = Role.GetAllChildRoles();
            roles.Add(Role);
            return roles;
        }
    }
}