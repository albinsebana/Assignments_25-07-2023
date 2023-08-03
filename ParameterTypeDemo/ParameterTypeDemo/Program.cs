using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterTypeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            Console.WriteLine("Orginal value"+number1);
            IncrementValue(ref number1);
            Console.WriteLine("in main function ->" + number1);

            int num1 = 10;
            int num2 = 20;
            int result;
            AddingValue(in num1, in num2, out result);
        }

        private static void AddingValue(in int num12, in int num22, out int result)
        {
            result = num12 + num22;
            Console.WriteLine("adition value: " + result);
        }

        private static void IncrementValue(ref int  num)
        {
            num++;
            Console.WriteLine("Inside the function ->" + num);
        }

        private static void ParamsArray() 
        {
            
        }
    }
}
