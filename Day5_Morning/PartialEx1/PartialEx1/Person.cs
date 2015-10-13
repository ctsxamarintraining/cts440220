using System;

namespace PartialEx1
{
	public partial class Person
	{
		public string Name;
		public int Age;
		public Person ()
		{
		}
		public void showName(){
			Console.WriteLine ("Name is " + this.Name);
		}
	}
}

