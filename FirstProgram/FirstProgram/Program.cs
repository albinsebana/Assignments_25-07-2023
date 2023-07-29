using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entr a number: ");
            int input= Convert.ToInt32(Console.ReadLine());
            //1
            CheckEvenOdd1(input);
            //2
            if (CheckEvenOdd2(input))//if true
                Console.WriteLine("Number is Even");
            else 
                Console.WriteLine("Number is odd");
            //3
            if (CheckEvenOdd3(input))//if true
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is odd");
            //4
            Console.WriteLine(CheckEvenOdd4(input));
            
        }
        static void CheckEvenOdd1(int inputNumber)
        {
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            { 
                Console.WriteLine("Number is Odd");
            }
        }
        static bool CheckEvenOdd2(int inputNumber)
        {
            if ((inputNumber % 2 == 0))
                return true;
            return false;

        }
        static bool CheckEvenOdd3(int inputNumber) 
        {
            return inputNumber % 2 == 0 ? true: false;
        }
        static string CheckEvenOdd4(int inputNumber)
        {
            return inputNumber % 2 == 0 ? "Number is Even": "Number is Odd";
        }
    }
}