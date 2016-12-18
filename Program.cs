/* C# Mikes user input through single dimensional array. 
 */
using System;

namespace InputArrays2016
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello Mike.\n\n");
			
			int[] numbers = new int[5];
			
			for (int i= 0; i<5; i++) 
			{
				//ask for user input:
				Console.WriteLine("Enter 5 numbers:");
				//store in array:
				numbers[i]= int.Parse(Console.ReadLine());
			}
			
			//loop through array.
			foreach (int j in numbers) {
				//write array.
				Console.WriteLine(j);
			}
			
			//pause to view and exit:
			Console.Write("Exit Mike...");
			Console.ReadKey(true);
		}
	}
}

