﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Homework.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<long>
    {
        public virtual ICollection<AppUserRole> UserRoles { get; set; }
    }
}
