using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CREDMVC12.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Amount { get; set; }
        public Customer() 
        {
        }
        public Customer(int id,string name,string email,int amt)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
            this.Amount = amt;
        }
    }
}
