using System;

class ArrayTest
{
    static void Main()
    {
        string[] fruits = {"Apple", "Mango", "Orange", "Jackfruit","Water Melon "};
        Console.WriteLine("Using for loop:\n");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine(fruits[i]);
        }
        Console.WriteLine("\nUsing foreach loop:\n");
        foreach (string s in fruits)
        {
            Console.WriteLine(s);
        }
    }
}
