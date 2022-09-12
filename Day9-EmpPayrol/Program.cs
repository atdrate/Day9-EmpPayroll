namespace EmployePayroll_Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chooes number\n1.EMp present absent\n2.Daily wages\n3.Part time wages\n4.using switch loop\n5. wages FOr Month\n6.using while loop\n7.Monthly emp wages\n8.wages for compnay");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    EmployPresentAbsent.EmployeeAttendance();
                    break;
                case 2:
                    DailyWage.CalculateDailyWage();
                    break;
                case 3:
                    ParttimeFullTime.CalculatePercentage();
                    break;
                case 4:
                    SwitchLoop.CalculateWage();
                    break;
                case 5:
                    WageForMonth.CalculateWageForMonth();
                    break;
                case 6:
                    WhileLoop.CalculateWage();
                    break;
                case 7:
                    EmpWagemonthly.CalculateEmpWages();
                    break;
                case 8:
                    UsingMultipleCompany.ComputeWaageForMultipleCompany("Suzuki", 20, 20, 100);
                    UsingMultipleCompany.ComputeWaageForMultipleCompany("BMW", 20, 20, 100);
                    UsingMultipleCompany.ComputeWaageForMultipleCompany("Infy", 20, 20, 100);
                    Console.WriteLine();
                    break;
               
                    Console.WriteLine("Entered Wrong choice");
                    break;

            }
        }
    }
}