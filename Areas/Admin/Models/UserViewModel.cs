using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TiggerAsp.Areas.Admin.Models
{
    public class UserViewModel
    {
        public IEnumerable<TiggerAsp.Models.User> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
