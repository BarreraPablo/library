﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Borrowing> Borrowings { get; set; }
    }
}
