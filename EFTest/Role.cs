using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFTest
{
    public class Role
    {
        public Role() {
            UsersInRole = new List<ExternalMember>();
        }

        [MaxLength(10)]
        public string Name { get; set; }

        public int RoleID { get; set; }

        public virtual List<ExternalMember> UsersInRole { get; set; }
    }
}