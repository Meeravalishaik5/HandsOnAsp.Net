using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCModelValidations.Models;
namespace HandsOnMVCModelValidations.Repositories
{
    public class UserRepository
    {
        public static List<User> list = new List<User>()
        {
            new User(){Name="Sk",Email="Sk@gmail.com",Uname="Sk",Password="123"}
        };
        public UserRepository() 
        {
        }
        public void Add(User item) 
        {
            list.Add(item);
        } 
        public User Validate(string uname,string pwd) 
        {
            foreach(var item in list) 
            {
                if(item.Uname==uname && item.Password == pwd) 
                {
                    return item;
                }
            }
            return null;
        }
    }
}
