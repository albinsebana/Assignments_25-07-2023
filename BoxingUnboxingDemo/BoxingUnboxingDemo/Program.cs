using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // assigned int value
            // 23 to num
            int num = 23;



            // boxing
           object boxedValue = num;

            // unboxing
            int i = (int)boxedValue;

            // Display result
            Console.WriteLine("Value of num (Orginal value) is : " + num);
            Console.WriteLine("Value of boxedValue  is : " + boxedValue);
            Console.WriteLine("Value of i(Unboxed value) is : " + i);
        }
    }
}
