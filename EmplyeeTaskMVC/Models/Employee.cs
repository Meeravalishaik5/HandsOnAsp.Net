﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyeeTaskMVC.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ProjName { get; set; }
        public string Password { get; set; }
    }
}
