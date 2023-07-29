using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int checkNumber = RandmNumber(0);
            int choice; //this variable is used in switch case
           // Console.WriteLine(checkNumber); //for printing the random number
            GuessNumber(checkNumber);

            while (true)
            {
                Console.WriteLine("Do you want play New Game ? \n New Game --> 1\n Exit   --> 2\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        checkNumber = RandmNumber(0);
                        //Console.WriteLine(checkNumber);// for printing the random number
                        GuessNumber(checkNumber);
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    // Add more cases as needed
                    default:
                        // Code block to execute when no case matches the expression
                        break;
                }
            }


            Console.ReadLine();
        }


        static int RandmNumber(int randomNumber) 
        {
            Random random = new Random();// Create a new instance of the Random class.
            randomNumber = random.Next(1, 11);// Generate a random number between 1 and 10 (inclusive).
            return randomNumber;
        }


        static void GuessNumber(int checkNumber) 
        {
            string result;
            int guessedNumber;
            int count=3;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Guess A number Between 1 and 10 you have total 3 tries\n");

                guessedNumber = Convert.ToInt32(Console.ReadLine());
                count--;
                if (checkNumber == guessedNumber)
                {
                    result = "you won";
                    Console.WriteLine(result);
                    break;

                }
                else
                {
                    if (checkNumber < guessedNumber)
                    {
                        result = "too high";
                        Console.WriteLine(result);
                        Console.WriteLine(count + " - more try\n");
                    }
                    else
                    {
                        result = "too low";
                        Console.WriteLine(result);
                        Console.WriteLine(count + " - more try\n");
                    }

                }

                if (count == 0)
                {
                    Console.WriteLine("<-----FAILED----->");
                    break;
                }
            }
            



        //    result = checkNumber == guessedNumber ? "you Won" : checkNumber < guessedNumber ? "too high" : "too Low";
          //  Console.WriteLine(result);  
        }
        
}
}
