using System;

namespace IntroToCSharp
{
	class HelloArray
	{
		static void Main(string[] args)
		{
			string[] fruits = {"apples", "bananas", "pears", "oranges"};
			
			Console.WriteLine("What is your favorite fruit?");
			
			string favFruit = Console.ReadLine();
			
			Console.WriteLine("Huh, " + favFruit + " is your favorite? Mine is " + fruits[2] + ".");
			
		
		}

	}
}