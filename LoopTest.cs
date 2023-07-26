using System;

class LoopTest
{
    static void Main()
    {
	int j = 0;
	int i = 0;
        string name = "Albin Sebana Kurian";
        Console.WriteLine("Using for loop:\n");
        for (i = 0; i < name.Length; i++)
        {
            Console.Write(name[i]);
        }
        Console.WriteLine("\nUsing while loop:\n");
        
        while (j < name.Length)
        {
            Console.Write(name[j]);
            j++;
        }
    }
}
