using System;
using System.Collections.Generic;

namespace ExtensionEx1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Write extention Methods for string for getting no of words, No of characters without white spaces.
			Console.WriteLine("Enter a string : ");
			string input = Console.ReadLine();
			Console.WriteLine ();
			Console.WriteLine ("Total words are : " + input.noOfWords() + "\nTotal characters are : " + input.noOfCharacters());

		}

	}
}
