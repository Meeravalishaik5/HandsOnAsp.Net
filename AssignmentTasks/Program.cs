using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name...");
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                for (; ; )
                {
                    Console.WriteLine("Please Enter your Name..");
                    name = Console.ReadLine();
                    if (!string.IsNullOrEmpty(name))
                    {
                        break;
                    }

                }
            }
            
            Console.WriteLine("Enter Year of Graduation...");
            string year = Console.ReadLine();
            int yy;
            while (!int.TryParse(year,out yy)) 
            {

            }
                Console.WriteLine("My Name is " + name + " I'll Graduate in Year " + year);
            Console.ReadKey();
        }
    }
}
