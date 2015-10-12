using System;

namespace Exceptionsample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] intArray = new int[10];
			int i = 0;
			do {
				try{
					Console.WriteLine("Enter an integer");
					int ele = Convert.ToInt32(Console.ReadLine());
					intArray[i++] = ele;
					int j = 0;
					string commaSepString = "";
					foreach (int arrEle in intArray){
						if(j==0){
							j++;
							commaSepString = commaSepString+arrEle;
						}
						else
							commaSepString = commaSepString + "," + arrEle ;
						
						
					}
					Console.WriteLine("The array elements are : "+commaSepString);

				}
				catch(IndexOutOfRangeException e){
					Console.WriteLine(e.Message);
				}
				catch(FormatException e){
					Console.WriteLine(e.Message);
				}
				catch(Exception e){
					Console.WriteLine(e.Message);
				}
				finally{
					Console.WriteLine("finally block");
				}
			} while(true);
		}
	}
}
