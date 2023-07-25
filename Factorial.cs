using System;
class AssignmentFactorial{
	public static void Main()
	{
		int number;
		int fact=1;
	Console.Write("enter any number to find factorial \n");
	number=int.Parse(Console.ReadLine());
	for(int i =1;i<=number;i++){
		fact=fact*i;
	}
	Console.WriteLine("factorial is :" + fact);
	}
}