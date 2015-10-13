using System;

namespace AnonymousMethodEx1
{
	class MainClass
	{
		delegate void Mydelegate(int x);
		public static void Main (string[] args)
		{
//			Create delegate and assign anonymous method to it and execute the method using delegate
			Mydelegate del = delegate(int x) {
				Console.WriteLine ("The number is " + x);
			};
			del (5);	
		}
	}
}
