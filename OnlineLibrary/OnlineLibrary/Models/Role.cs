﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class Role
    {
        public User User { get; set; }
        public User Librarian { get; set; }

    }
}