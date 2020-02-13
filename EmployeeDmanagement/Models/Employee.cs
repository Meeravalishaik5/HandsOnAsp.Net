using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDmanagement.Models
{
    public enum Dept 
    {
        IT,Finance,Healthcare
    }
    public class Employee
    {
        public int ID { get; set; }
        public string name { get; set;}
        public string Email { get; set; }
        public Dept dept { get; set; }
    }
}
