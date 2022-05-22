using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T firstvalue, secondvalue,thirdvalue;

        public GenericMaximum(T firstvalue, T secondvalue, T thirdvalue, T[] value)
        {
            this.firstvalue=firstvalue;
            this.secondvalue=secondvalue;
            this.thirdvalue=thirdvalue;
            this.value=value;
        }


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
            return default;
        }
        public T MaxMethod()
        {
            T max = GenericMaximum<T>.MaxValue (this.firstvalue, this.secondvalue, this.thirdvalue);
            return max;
        }
        
    }
}
