using System;

namespace GarbageCollectionEx1
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.WriteLine ("Total memory before using memory : {0}", GC.GetTotalMemory (false));

			string name = "adil";
			int[] intArray = new int[100];
			int[,,] int3DArray = new int[100,100,100];
			Console.WriteLine ("Total Memory after using memory : {0}", GC.GetTotalMemory (false));

			GC.Collect ();

			Console.WriteLine ("Total Memory after using garbage collector : {0}", GC.GetTotalMemory (false));

		}
	}
}
