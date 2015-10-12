using System;
using System.IO;

namespace FileEx3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TextReader input = new StreamReader ("1MB.txt");
			TextWriter output = new StreamWriter ("1mbDup.txt");
			char[] buffer = new char[500];
			int read;
			while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
			{
				output.Write (buffer, 0, read);
			}
			input.Close ();
			output.Close ();
		}
	}
}
