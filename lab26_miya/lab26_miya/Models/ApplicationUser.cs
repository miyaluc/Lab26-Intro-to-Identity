﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab26_miya.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Circumstances
        {
            get; set;
        }
    }
}
