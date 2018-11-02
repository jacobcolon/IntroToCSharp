using System;

namespace IntroToCSharp
{
	class HelloForLoop
	{
		static void Main(string[] args)
		{
			
			string greeting = "Hello ForLoop";
			int loopCount = 0;

			for(int n = 5; loopCount < n; loopCount++)
			{
				Console.WriteLine(greeting);
			}
	
		}

	}
}