using System;

namespace IntroToCSharp
{
	class HelloFuntion
	{
		static void Main(string[] args)
		{
			string greeting = FuntionSample(); 
			Console.WriteLine(greeting);	
		}
		
		static string FuntionSample()
		{
			return "Hello Funtion";
		}
	}
}