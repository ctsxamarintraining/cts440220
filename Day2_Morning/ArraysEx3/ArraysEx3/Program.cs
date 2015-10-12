using System;

namespace ArraysEx3
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

			Array.Sort (personArray);
			foreach (Person p in personArray) {
				Console.WriteLine (p.firstName);
			};

		}
	}
	class Person : IComparable<Person>
	{
		public string firstName;
		public string lastName;
		public int age;
		public int CompareTo(Person other)
		{
			// Default to age sort. [High to low]
			return other.age.CompareTo(this.age);
		}
	}
}
