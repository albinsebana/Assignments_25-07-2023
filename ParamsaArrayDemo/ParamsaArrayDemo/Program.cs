using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsaArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintNumber(1, 2, 3);

        }

        private static void PrintNumber(params int[] numberSum)
        {
            foreach(int i in numberSum)
            {
                Console.WriteLine("elements in PArams Array: "+i);
            }
            int sum = numberSum.Sum();
            Console.WriteLine("Sum of PArams  array : "+sum);
        }
    }
}
