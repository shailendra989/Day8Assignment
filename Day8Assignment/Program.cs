namespace Day8Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (EmployUtil.isPresent() == true)
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("absent");
            }
            int x = EmployUtil.employwageCalculation();
            Console.WriteLine(x);

           int y = EmployUtil.partTimeWage();
            Console.WriteLine(y);

       //     Console.WriteLine( "input choice - :");
       //     int empStatus = Convert.ToInt32(Console.ReadLine());
//            EmployUtil.wage(empStatus);

            int  z =EmployUtil.wagePerMonthSalary();
            Console.WriteLine(z);

            EmployUtil.conditionHours();


        }
    }
}