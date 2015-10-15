using System;
using System.Collections.Generic;

namespace CollectionEx4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Using .Net provided List<T> and Dictionary<Tkey,TValue>, perform operations for 
//				Add,AddRange, Remove, Contains, InsertAt, Clear.
			List<int> myList = new List<int>();
			myList.Add (1);
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.AddRange (new List<int> (){ 2, 3, 4 });
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.Remove (2);
			Console.WriteLine ("Element deleted is 2");
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.Insert (1, 2);
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.Clear ();
			Console.WriteLine ("list is cleared");



			Dictionary<int,string> myDictionary = new Dictionary<int, string> (){{2,"Popeye"},{3,"Dhoni"}};
			myDictionary.Add (4, "John");
			Console.WriteLine ("Keys in Dictionary are");
			foreach (int ele in myDictionary.Keys)
				Console.WriteLine (ele);
			Console.WriteLine ("Values in Dictionary are");
			foreach (string ele in myDictionary.Values)
				Console.WriteLine (ele);
			myDictionary.ContainsValue ("John");
			myDictionary.Remove (4);
			Console.WriteLine ("Keys in Dictionary are");
			foreach (int ele in myDictionary.Keys)
				Console.WriteLine (ele);
			Console.WriteLine ("Values in Dictionary are");
			foreach (string ele in myDictionary.Values)
				Console.WriteLine (ele);
			myDictionary.Clear ();

		}
	}
}
