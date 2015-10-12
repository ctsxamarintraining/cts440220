using System;
using System.IO;
using System.Collections.Generic;


namespace FileEx1
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			File.Delete("OriginalFile.txt");
			File.Delete("ReversedFile.txt");
			using (StreamWriter source_FileWriter = new StreamWriter ("OriginalFile.txt")) {
				source_FileWriter.WriteLine ("line1");
				source_FileWriter.WriteLine ("line2");
				source_FileWriter.WriteLine ("line3");

			}


			Console.WriteLine ("The contents of original file are");
			using (StreamReader source_StreamReader2 = new StreamReader ("OriginalFile.txt")) {
				Console.WriteLine (source_StreamReader2.ReadToEnd());
			}



			List<string> ListOfLines = new List<string>();
			using (StreamReader source_StreamReader = new StreamReader("OriginalFile.txt"))
			{
				string line;
				while ((line = source_StreamReader.ReadLine()) != null)
				{
					ListOfLines.Add(line); 
				}
			}

			ListOfLines.Reverse();

			using (StreamWriter destination_StreamWriter = new StreamWriter ("ReversedFile.txt")) {
				foreach (string line in ListOfLines) {
					destination_StreamWriter.WriteLine (line);
				}
			}


			Console.WriteLine ("The contents of reversed file are");
			using (StreamReader destination_StreamReader = new StreamReader ("ReversedFile.txt")) {
				Console.WriteLine (destination_StreamReader.ReadToEnd());
			}
			Console.ReadLine ();
		}
	}
}
