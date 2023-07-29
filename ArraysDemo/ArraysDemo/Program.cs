using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] names = { "Albin", "akash", "amak", "alan" };
            string[] capitalNames = CapitalizeName(names);
            string[] studentName = new string[3];
            Console.WriteLine("enter 3 Students Name");
            for (int i = 0; i < studentName.Length; i++)
            {
                studentName[i]=Console.ReadLine();  

            }
            PrintStudentsName(studentName);
        }
        static void PrintStudentsName(string[] sname)
        {
            foreach (string student in sname)
            { 
                Console.WriteLine("hello welcome "+ student);
            }
        }
        static string[] CapitalizeName(string[] names)
        {
            string[] capitalizedNames = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                capitalizedNames[i] = names[i].ToUpper();
            }
            return capitalizedNames;    


        }

    }
}
