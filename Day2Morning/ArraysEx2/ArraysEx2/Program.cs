using System;

namespace ArraysEx2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,,,] string4DArray = new string[2, 2, 2, 2] { { { 
						{ "1", "2" }, { "3", "4" }  
					}, { 
						{ "5", "6" }, { "7", "8" }  
					} 

				}, { { 
						{ "9", "10" }, { "11", "12" }
					}, { 
						{ "13", "14" }, { "15", "16" }
					} 
				} 
			};
			int[,] int2DArray = new int[,] {
				{ 1, 2 },
				{ 3, 4 }
			};
			printArray (string4DArray);
			printArray (int2DArray);


		}
		public static void printArray(Array anyArray){
			foreach (var value in anyArray) {
				Console.WriteLine (value);
			}
			Console.WriteLine ("Printed");
		}
	}
}
