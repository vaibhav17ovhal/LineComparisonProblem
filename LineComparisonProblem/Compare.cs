using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Compare
    {
        public static int line1;
        public static int line2;
        
        public static int LengthOne()
        {
            Console.Write("Enter the length of line1: ");
            line1 = Convert.ToInt32(Console.ReadLine());
            return line1;
        } 

        public static int LengthTwo()
        {
            Console.Write($"Enter the length of line2: ");
            line2 = Convert.ToInt32(Console.ReadLine());
            return line2;
        }

        public void Check()
        {
            line1 = LengthOne();
            line2 = LengthTwo();

            if (line1.CompareTo( line2) == 0)
            {
                Console.WriteLine("Both the lines are equal.");
            }
            else
            {
                Console.WriteLine("The lines are different.");
            }
        }
    }
}
