using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployePayroll_Day10
{
    internal class EmployPresentAbsent
    {
        public static void EmployeeAttendance()
        {

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
