using System;

namespace IntroToCSharp
{
	class HelloSwitch
	{
		static void Main(string[] args)
		{
			 Console.WriteLine("Pick a number, 1 or 2.");
			 int number = Int32.Parse(Console.ReadLine());
      
			switch (number)
			{
				case 1:
					Console.WriteLine("Your number is 1");
					break;
				case 2:
					Console.WriteLine("Your number is 2");
					break;
				default:
					Console.WriteLine("I said pick either 1 or 2.");
					break;
			}
			
	
		}

	}
}