﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Shared.Models
{
    public class Role
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isDeleted { get; set; }
    }
}