using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreApplication.Models
{
    public class Employee
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public Dept Dept { get; set; }
        [ValidateDomain(allowdomain:"cts.com")]
        [Remote(action:"IsEmailExist",controller:"Default")]
        public string Email { get; set; }
        public Employee(int i,string n,Dept d,string em) 
        {
            this.id = i;
            this.name = n;
            this.Dept = d;
            this.Email = em;
        }
        
    }
}
