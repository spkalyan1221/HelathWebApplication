using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HelathWebApplication.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the HelathWebApplicationUser class
    public class HelathWebApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string Firstname { get; set; }
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string Lastname { get; set; }
    }
}
