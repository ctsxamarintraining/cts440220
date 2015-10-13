using System;

namespace AnonymousTypeEx1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Create anonymous type with properties Name, Id and City and print them in console. 
			Person p = new Person{Name="John",Id=1,City="Hyderabad"};
			Console.WriteLine ("The person name is {0}, Id is {1} , City is {2}", p.Name, p.Id, p.City);
		}
	}
	public class Person{
		public string Name;
		public int Id;
		public string City;
	}
}
