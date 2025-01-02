﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace InveonFinal.Core.Models
{
    public class AppUser : IdentityUser<string>
    {
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string? ProfilePictureUrl { get; set; }
    }
}
