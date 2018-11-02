using System;

namespace IntroToCSharp
{
	class HelloInPut
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your name?");
			
			string name = Console.ReadLine();
			
			Console.WriteLine("Hello " + name + "!");
	
		}

	}
}