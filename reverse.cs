using System;
class ReverseNumber{
	public static void Main()
	{
		int number,reminder;
		int reverse=0;

		Console.Write("enter a number");
		number=int.Parse(Console.ReadLine());

		while(number!=0)
		{
			reminder=number%10;
			reverse=reverse*10+reminder;
			number/=10;
		}   
		Console.Write("Reversed Number: "+reverse);   
	}
}