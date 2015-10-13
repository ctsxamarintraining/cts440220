using System;

namespace PartialEx1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Create the partial classes in two file with two methods each. And call them in main method.
			Person p = new Person{Name = "John",Age = 20};
			p.showName ();
			p.showAge ();

		}
	}
}
