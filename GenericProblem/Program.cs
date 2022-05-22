using System;

namespace GenericProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(12, 75, 90);
            Console.WriteLine(output);

            double  doubleoutput1 = MaximumNumberCheck.MaximumdoubleNumber(12.5, 16.7, 56.5);
            Console.WriteLine(doubleoutput1);

            string stringOutput = MaximumNumberCheck.MaximumStringNumber("11", "22", "56");
            Console.WriteLine(stringOutput);

        }


    }
}