﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWorkers.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Boss { get; set; }
    }
}