using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int storeInt;


            //string myStr = "albin";
            string myStr = "19";


            result = int.TryParse(myStr, out storeInt);
           Console.WriteLine("String is a numeric representation: " + result);


            Console.WriteLine("============================================================================" );


            string message = int.TryParse(myStr, out storeInt) ? "Parsing successful!\nParsed integer value: " + storeInt : "Parsing failed. The input is not a valid integer.";
            Console.WriteLine(message);
        }
    }
}
