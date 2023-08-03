using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0, fact = 1;
            Console.WriteLine("Enter a number to find factorial ");
            number = Convert.ToInt32(Console.ReadLine());//  string->int

            bool b = Factorial( in number, out fact);

            Console.WriteLine("Factorial of the "+number+ " is: " + fact);
            Console.WriteLine(b ? "IT'S A PRIME NUMBER" : "IT'S NOT A PRIME NUMBER");
        }

        private static bool Factorial(in int number, out int fact)
        {
            fact = 1;

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }


            for (int k = 2; k <= number/2; k++)//sqr root of number also
            {
                if (number % k == 0)
                    return false;
            }

            return true;
        }

    }
}