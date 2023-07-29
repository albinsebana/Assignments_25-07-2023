using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureHuntGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------WELCOME TO TREASURE ISLAND---------------------");
            Console.WriteLine("<-- YOUR MISSION IS TO FIND THE TREASURE -->");
            Console.WriteLine("Where you want go ? LEFT or RIGHT \n LEFT -> 0\n RIGHT -> 1 \n");//  choose the option 

            int choice1 = Convert.ToInt32(Console.ReadLine()); // input converted from string to integer

            if (choice1 == 1)
            {
                Console.WriteLine(" 🕳️ FALL INTO THE HOLE 🤸‍🕳️");
                Console.WriteLine("☆*: .｡. o(≧ GAME OVER ≦)o .｡.:*☆");
            }
            else
            {
                Console.WriteLine("Do you want to  :\n SWIM -> 0 \n WAIT -> 1\n");
                int choice2 = Convert.ToInt32(Console.ReadLine()); //input converted from string to integer

                if (choice2 == 1)
                {
                    Console.WriteLine("ATTACKED BY TROUT  \n GAME OVER");
                }
                else
                {
                    Console.WriteLine("Which door you wast to select: \n RED -> 0 \n BLUE -> 1 \n YELLOW -> 2 \n ANYTHING ELSE -> 3\n");
                    int choice3 = Convert.ToInt32(Console.ReadLine()); //input converted from string to integer

                    if (choice3 == 1)
                    {
                        Console.WriteLine("EATEN BY THE BEAST\n GAME OVER");
                    }
                    else if (choice3 == 0)
                    {
                        Console.WriteLine("BURNED BY FIRE \n GAME OVER");
   
                    }
                    else if (choice3 == 2)
                    {
                        Console.WriteLine(" YOU WIN");
                    }
                    else if (choice3 == 3)
                    {

                        Console.WriteLine("GAME OVER");
                    }
                    else
                    {
                        Console.WriteLine("INVALID CHOICE");
                        Console.WriteLine("GAME OVER");
                    }
                }
            }
        }

    }
}