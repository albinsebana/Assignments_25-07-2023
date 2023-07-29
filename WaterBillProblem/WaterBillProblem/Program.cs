using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBillProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MeterCharge = 75;
            int TotalBillAmount = 0;
            int charge = 0;
            Console.WriteLine("WATER BILL CALCULATOR");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Enter the number of Unit Consumed : \n");
            int units = Convert.ToInt32(Console.ReadLine());//CONVERTING STRING TO INT 
            if (units <= 100)
            {
                charge = units * 5;
                TotalBillAmount = charge + MeterCharge;
                Console.WriteLine("Total Water Bill Amount : " + TotalBillAmount);
            }
            else
            {
                if (units <= 250)
                {
                    charge = units * 10;
                    TotalBillAmount = charge + MeterCharge;
                    Console.WriteLine("Total Water Bill Amount: " + TotalBillAmount);
                }
                else
                {
                    charge = units * 20;
                    TotalBillAmount = charge + MeterCharge;
                    Console.WriteLine("Total Water Bill Amount : " + TotalBillAmount);
                }
            }
        }
    }
}