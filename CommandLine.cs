using System;
using System.Linq;

namespace CommandLineArgs
{
    class Program
    {
       public static void Main(string[] args)
        {
	    int sum=0;
	    int temp=0;
	    int average=0;
            int max =0;
            int min = 0;

            int[] numbers = args.Select(int.Parse).ToArray();
            int count = numbers.Length;
	    for(int i=0;i<count;i++)
		{
			Console.WriteLine("Elements Entered in CLI " +args[i]);
		}
Console.WriteLine("-----------------------------------------------------------------------------");  
       
	    for (int i=0;i<count;i++)
		{
			sum=sum+numbers[i];
		}
            
	    average =sum / count;

Console.WriteLine("-----------------------------------------------------------------------------");

	    	for(int i=0;i<count;i++)	
		{
			for(int j=0;j<count;j++)
			{
				if(numbers[i]<numbers[j])
				{
				temp=numbers[i];
				numbers[i]=numbers[j];
				numbers[j]=temp;
				}
		
			}
		}
		
		
		max=numbers[count-1];
		min=numbers[0];
Console.WriteLine("-----------------------------------------------------------------------------");




            Console.WriteLine("Length of Array:"+ count);
            Console.WriteLine("sum of array elements:"+ sum);
            Console.WriteLine("Average of array elements:"+average);
            Console.WriteLine("Largest element of array :"+max);
            Console.WriteLine("smallest element of array:"+min);
        }
    }
}