using System;
class PrimeNumber{
	public static void Main()
	{
	int number;
	int count=0;
	
	Console.Write("enter a number check whether prime or not : \n");
	number=int.Parse(Console.ReadLine());
	for(int i=1;i<=number;i++)
		{
		if(number % i ==0){
			count++;
			}
		}
	if(count > 2){
	Console.WriteLine("NOt a Prime Number");
	
	}
	else{
	Console.WriteLine(" It is a prime number ");
	}
	}
}