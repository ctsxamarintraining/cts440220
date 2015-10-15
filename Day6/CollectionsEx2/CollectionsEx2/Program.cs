using System;
using System.Collections.Generic;

namespace CollectionsEx2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Implement IList<T> interface and perform operations to add, remove, contains, clear all.
//			Note: use only a array as backing field in your class, do not use default list classes provided by .NET
			MyList<int> myList = new MyList<int>();
			myList.add (1);
			myList.add (2);
			myList.add (3);
			myList.add (4);
			Console.WriteLine("my list has : "+myList.Count +" elements");
			Console.WriteLine("my list has 1 : "+myList.contains (1));
			myList.removeEle (1);
			Console.WriteLine("my list has 1 : "+myList.contains (1));
			Console.WriteLine("my list has : "+myList.Count +" elements");
			myList.clearAll ();

			Console.WriteLine("my list has : "+myList.Count +" elements");
		}

	}
	class MyList<T> : IList<T>{
		public void Add (T item)
		{
			throw new NotImplementedException ();
		}

		public void Clear ()
		{
			throw new NotImplementedException ();
		}

		public bool Contains (T item)
		{
			throw new NotImplementedException ();
		}

		public void CopyTo (T[] array, int arrayIndex)
		{
			throw new NotImplementedException ();
		}

		public bool Remove (T item)
		{
			throw new NotImplementedException ();
		}

		public int Count {
			get {
				return _index+1;
			}
		}

		public bool IsReadOnly {
			get {
				throw new NotImplementedException ();
			}
		}

		public IEnumerator<T> GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		T[] listArray= new T[10];
		int _index;
		T myval;
		public T this [int index] {
			get { return myval; }
			set { myval = value; }
		}
		public MyList(){

			_index = -1;
		}
		//
		// Methods
		//
		public int IndexOf (T item){
			for (int i = 0; i < this._index; i++) {
				if (listArray [i].Equals(item))
					return i;
			}
			return -1;
		}

		public void Insert (int index, T item){
			if (index < listArray.Length) {
				listArray [index] = item;
			}
			else
				Console.WriteLine ("Exceeded array");
		}

		public void RemoveAt (int index){
			for (int i = index; i < this._index; i++) {
				listArray [i] = listArray [i + 1];

			}
			_index--;
		}
		public void add(T item){
			this._index++;
			Insert (this._index, item);
			Console.WriteLine (item+" is added to List");
		}
		public void removeEle(T item){
			if (IndexOf (item) > -1) {
				RemoveAt (IndexOf (item));
				Console.WriteLine ("Element deleted is "+item);
			} else
				Console.WriteLine ("No element");
		}
		public bool contains(T item){
			if (IndexOf (item) > -1) {
				return true;
			} else
				return false;
		}
		public void clearAll(){
			this._index = -1;
			Console.WriteLine ("List Cleared");
		}
	}
}
