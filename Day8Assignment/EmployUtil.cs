using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment
{
    internal class EmployUtil
    {
        public static int empworkhourInDay = 8;
       public static int parttimehour = 4;
        public   static bool isPresent()
        {
            Random random = new Random();
            int x = random.Next(0, 2);

            if (x == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
     public static int employwageCalculation()
        {
            int empwageperhour = 20;
            ;


            int salaryPerDay = empwageperhour* empworkhourInDay;

            return salaryPerDay;
        }
        public static int partTimeWage()
        {
            

            int salaryPartTime = parttimehour * empworkhourInDay;
            return salaryPartTime;
            
        }

        public static void wage(int choice) 
        {
            switch(choice)
            {
                case 0 : Console.WriteLine("absent");
                    break;
                case 1 : Console.WriteLine(partTimeWage());
                    break;
                case 2 : Console.WriteLine(employwageCalculation());
                    break;
                default: Console.WriteLine("Wrong Input");
                    break;
                    

                    
            }

        }
       
        public static int wagePerMonthSalary()
        {
            int workPerMonth = 20;
            int salaryPerMonth = workPerMonth * employwageCalculation() ;
            return salaryPerMonth;
        }

        public static bool  isparttime()
        {
            Random random = new Random();
            int x = random.Next(0, 2);

            if (x == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void conditionHours()
        {
            int empHrs = 0;
            int days = 0;
            for(int i =1;i<=30;i++) {
                if (isPresent() == true)
                {
                    days++;
                    empHrs = empHrs + empworkhourInDay;
                    if (isparttime())
                    {
                        empHrs = empHrs + parttimehour;

                    } 

                }
                if(empHrs >= 100 )
                {
                    Console.WriteLine("hour reached");
                    break;
                }
                if( days>= 20 ) {
                    Console.WriteLine("days reached");
                }
            }

        }
        
    }
}    

