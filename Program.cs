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
            EmployeeWage dmart = new EmployeeWage("DMart", 20, 2, 10);
            EmployeeWage reliance = new EmployeeWage("Reliance", 10, 4, 20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.tostring());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.tostring());
            Console.ReadLine();
        }
    }
}