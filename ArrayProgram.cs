using System;
class ProgramArray
{
public static void Main()
	{
	int i,j,size,temp;
	double sum=0,average=0;
	Console.Write("enter the size of the array :\n");
	size=int.Parse(Console.ReadLine());

	int [] arr=new int[size];

	for(i=0;i<size;i++){
	Console.Write("enter the elemnts\n");
	arr[i]=int.Parse(Console.ReadLine());	
	}

	for(i=0;i<size;i++)
	{
		sum=sum+arr[i];
	}
	
	Console.WriteLine("Sum of the Elemnts :"+ sum);
	Console.WriteLine("-----------------------------------------------------------------------------");
	average =sum / size;
	Console.WriteLine("Average of the Elemnts :"+ average);
	Console.WriteLine("-----------------------------------------------------------------------------");
	Console.WriteLine("");

	for(i=0;i<size;i++)	
	{
		for(j=0;j<size;j++)
		{
		if(arr[i]<arr[j])
			{
				temp=arr[i];
				arr[i]=arr[j];
				arr[j]=temp;
			}
		
		}
	}
Console.WriteLine("Biggest(MAX) element in the array"+arr[size-1]);
	Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine("Smallest(MIN) element in the array"+arr[0]);


	Console.WriteLine("-----------------------------------------------------------------------------");
	}
	

}