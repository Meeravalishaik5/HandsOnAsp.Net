using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreApplication.Models
{
    public  interface EmployeeManagement
    {
        Employee GetEmployee(int id);
        List<Employee> DisplayDetails();
        void AddEmployee(Employee employe2);
    }
    
}
