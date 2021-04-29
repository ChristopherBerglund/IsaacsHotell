using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace IsaacsHotell.Data
{
    public class Användare : IdentityUser
    {
        [PersonalData]
        [Required]
        public string Namn { get; set; }
        [PersonalData]
        [Required]
        public string Efternamn { get; set; }
    }
}
