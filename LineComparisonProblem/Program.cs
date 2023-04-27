using System;

namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program.");

            Console.WriteLine("==============X=============");

            Operation.LengthOfLine();

            Console.WriteLine("==============X=============");

            Operation.EqualityCheck(15 , 15.5);
        }
    }
}
