using System;

namespace ExtensionEx2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Create Nullable Type. Assign null and to print value in console. 
//			Assign a value and print value in console
			int? nullableInt;
			nullableInt = null;
			if(!nullableInt.HasValue)
			Console.WriteLine ("The value is null ");
			nullableInt = 20;
			if(nullableInt.HasValue)
			Console.WriteLine ("The value is " + nullableInt.Value);
		}
	}
}
