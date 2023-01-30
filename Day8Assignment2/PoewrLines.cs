using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment2
{
    internal class PoewrLines
    {
        public static double calculation(double  x1, double y1,double x2,double y2)
        {
            double length = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            return length;
        }

        public static  string compareLenth(double x1, double y1, double x2, double y2,double a1,double b1,double a2,double b2 )
        {
            double length1 = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            double length2 = Math.Sqrt((Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2)));

            if(length1 == length2) 
            {
                return "equal";
                
            }
            if(length1 > length2)
            {
                return "length1 is bigger";
            }
            else
            {
                return "length2 is bigger";
            }
        }
    }


}
