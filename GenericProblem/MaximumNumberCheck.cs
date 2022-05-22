using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    internal class MaximumNumberCheck
    {
        public static int MaximumIntegerNumber(int firstvalue, int secondvalue, int thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >0 ||
                firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
                firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >=0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >0 ||
               secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
               secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >=0)
             {
                return secondvalue;
              }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >0 ||
               thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
               thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >=0)
            {
                return thirdvalue;
            }
            throw new Exception("firstNumber,SecondNumber,thirdNumber are same");
        }

        public static double MaximumdoubleNumber(double firstvalue, double secondvalue, double thirdvalue)
            {
                if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >0 ||
                    firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
                    firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >=0)
                {
                    return firstvalue;
                }
                if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >0 ||
                   secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                   secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >=0)
                {
                    return secondvalue;
                }
                if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >0 ||
                   thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
                   thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >=0)
                {
                    return thirdvalue;
                }
                throw new Exception("firstNumber,SecondNumber,thirdNumber are same");
            }
        public static string MaximumStringNumber(string firstvalue, string secondvalue, string thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >0 ||
                firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
                firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >=0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >0 ||
               secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
               secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >=0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >0 ||
               thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
               thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >=0)
            {
                return thirdvalue;
            }
            throw new Exception("firstNumber,SecondNumber,thirdNumber are same");
        }

    }
}
