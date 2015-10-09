using System;
using System.Collections.Generic;

namespace ArrayEx4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] personArray = new Person[3] {
				new Person{ firstName = "John", lastName = "Daniel", age = 10 },
				new Person{ firstName = "Kiran", lastName = "Kumar", age = 20 },
				new Person{ firstName = "Shiva", lastName = "Prasad", age = 15 }
			};
			MyComparer myComparer = new MyComparer ();
			Array.Sort (personArray,myComparer);
			foreach (Person p in personArray) {
				Console.WriteLine (p.firstName);
			};

		}
	}
	class Person 
	{
		public string firstName;
		public string lastName;
		public int age;

	}
	class MyComparer : IComparer<Person>
	{
		public int Compare(Person e1, Person e2)
		{
			return e1.age.CompareTo(e2.age);
		}
	}
}
