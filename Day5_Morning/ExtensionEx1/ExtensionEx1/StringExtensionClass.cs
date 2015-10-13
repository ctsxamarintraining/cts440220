using System;
using System.Collections.Generic;

namespace ExtensionEx1
{
	public static class StringExtensionClass
	{
		
		public static int noOfWords(this string input){
			string[] listOfWords = input.Split (new char[]{ ' ', '.' });
			return listOfWords.Length;
		}
		public static int noOfCharacters(this string input){
			char[] charArray = input.ToCharArray ();
			int count = 0;
			foreach (char c in charArray) {
				if (!char.IsWhiteSpace (c))
					count++;
			}
			return count;
		}
	}
}

