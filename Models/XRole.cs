using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace XtendUsersRoles.Models
{
    public class XRole : IdentityRole
    {
        public XRole() : base() { }

        public DateTime CreatedDate { get; set; }
    }
}