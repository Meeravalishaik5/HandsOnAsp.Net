using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreApplication.Models
{
    public class EmployeeRepository: EmployeeManagement
    {
       public  List<Employee> elist;
        public EmployeeRepository() 
        {
            elist = new List<Employee>() { new Employee(1,"SK",Dept.Accounts,"Sk@gmail.com"),new Employee(2,"MS",Dept.HealthCare,"sk@df.com"), new Employee(3, "SM", Dept.IT,"ad@sdd.com") };
        }
        public Employee GetEmployee(int id1) 
        {
            Employee el = elist.FirstOrDefault(e => e.id == id1);
            //foreach(Employee x in e) 
            //{
            //    if (x.id == id)
            //        return x;
            //}
            return el;
        }
        public List<Employee> DisplayDetails()
        {
            return elist;
            //throw new NotImplementedException();
        }
        public void AddEmployee(Employee emp) 
        {
            //emp.id = elist.Max(e => e.id) + 1;
            elist.Add(emp);
            //return true;
        }

    }
}
