using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            Random random = new Random();

            int empInput = random.Next(0, 2);
            if (isPresent == empInput)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
                Console.ReadLine();
        }
    }
}
