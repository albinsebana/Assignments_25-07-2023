using System;
class Fibinacci{
	public static void Main()
	{
		
		int firstNumber=0;
		int secondNumber=1;
		int thirdNumber=0;
		Console.WriteLine("Fibinacci Series\n");
		Console.WriteLine(firstNumber+"\n"+secondNumber);
		for(int i=0;i<6;i++){
			thirdNumber=firstNumber+secondNumber;
			Console.WriteLine(thirdNumber);
			firstNumber=secondNumber;
			secondNumber=thirdNumber;	
		}
		
	}
}