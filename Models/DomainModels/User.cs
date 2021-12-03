using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;  // for NotMapped attr

namespace TiggerAsp.Models
{
    public class User : IdentityUser
    {
        [NotMapped]
        public IList<string> Rolenames { get; set; }
    }
}
