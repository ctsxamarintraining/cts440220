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
			Console.WriteLine ("Sort by age");
			Array.Sort (personArray,new MyAgeComparer());
			foreach (Person p in personArray) {
				Console.WriteLine (p.firstName + " " + p.lastName + "Age : "+p.age);
			};
			Console.WriteLine ();
			Console.WriteLine ("Sort by first name");
			Array.Sort (personArray,new MyFirstNameComparer());
			foreach (Person p in personArray) {
				Console.WriteLine (p.firstName + " " + p.lastName + "Age : "+p.age);
			};
			Console.WriteLine ();
			Console.WriteLine ("Sort by last name");
			Array.Sort (personArray,new MyLastNameComparer());
			foreach (Person p in personArray) {
				Console.WriteLine (p.firstName + " " + p.lastName + "Age : "+p.age);
			};

		}
	}
	class Person 
	{
		public string firstName;
		public string lastName;
		public int age;

	}
	class MyAgeComparer : IComparer<Person>
	{
		public int Compare(Person e1, Person e2)
		{
			return e1.age.CompareTo(e2.age);
		}
	}
	class MyFirstNameComparer : IComparer<Person>
	{
		public int Compare(Person e1, Person e2)
		{
			return e1.firstName.CompareTo(e2.firstName);
		}
	}
	class MyLastNameComparer : IComparer<Person>
	{
		public int Compare(Person e1, Person e2)
		{
			return e1.lastName.CompareTo(e2.lastName);
		}
	}
}
