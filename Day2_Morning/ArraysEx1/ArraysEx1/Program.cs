using System;

namespace ArraysEx1
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
			foreach (string number in string4DArray) {
				Console.WriteLine (number);
			}
		}
	}
}
