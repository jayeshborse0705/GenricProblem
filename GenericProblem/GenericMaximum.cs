using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public  class GenericMaximum<T> where T : IComparable
    {
        public T[] value;

        public GenericMaximum(T[] value)
        {
            this.value = value; 
        }
        public T[] sort(T[] values)
        {
            Array.Sort(this.value, values);
            return values;
        }
        public T Maxvalue(params T[] values)
        {
            var sorted_values=sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = Maxvalue(this.value);
            return max;
            
        }
        public void PrintMaxValue()
        {
            var max=Maxvalue(this.value);
            Console.WriteLine("Maximum value is:" +max);
        }


    }
}
