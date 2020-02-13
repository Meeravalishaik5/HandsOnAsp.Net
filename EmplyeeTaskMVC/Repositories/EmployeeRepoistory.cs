using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmplyeeTaskMVC.Models;
namespace EmplyeeTaskMVC.Repositories
{
    public class EmployeeRepoistory
    {
        public static List<Employee> list = new List<Employee>()
        {
            new Employee(){EmpId=1,Name="SK",Password="123"}
        };
        public EmployeeRepoistory()
        {
        }
        public void Add(Employee item)
        {
            list.Add(item);
        }
        public Employee Validate(int eid, string pwd)
        {
            foreach (var item in list)
            {
                if (item.EmpId == eid && item.Password == pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
