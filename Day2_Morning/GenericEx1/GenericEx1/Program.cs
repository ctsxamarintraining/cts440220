using System;

namespace GenericEx1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Console.WriteLine ("Integer linked List");
			MyLinkedList<int> linkedList = new MyLinkedList<int>();
			linkedList.Add (1);
			linkedList.Add (2);
			linkedList.Add (3);
			linkedList.Add (4);

			Console.WriteLine ("All Elements are");
			linkedList.printAllElements ();

			Console.WriteLine ("Deleting 3");
			linkedList.Delete (3);

			Console.WriteLine ("All Elements are");
			linkedList.printAllElements ();
		}
	}

	class MyLinkedList<T>{

		public Node<T> head;
		public int count {
			get ;
			set ;
		}
		public  MyLinkedList(){
			count = 0;
		}

		public void Add(T data) {
			try{
				Node<T> toAdd = new Node<T>();
				toAdd.data = (T)data;
				toAdd.next = null;
				if (head == null) {
					head = toAdd;
				}
				else
				{
					Node<T> current = head;
					while (current.next != null)
					{
						current = current.next;
					}

					current.next = toAdd;
				}
				count++;
			}
			catch(Exception e){
				Console.WriteLine (e.Message);
			}
		}
		public void printAllElements(){
			if (head == null)
				Console.WriteLine ("No Data");
			else {
				Node<T> current = head;
				do {
					Console.WriteLine (current.data);
					current = current.next;
				} while (current.next != null);
				Console.WriteLine (current.data);
			}
		}
		public void Delete(T data)
		{
			try{
				bool dataFound = false;
				if (head == null) {
					Console.WriteLine ("Data not found");
					return;
				}
				if (head.data.Equals(data)) 
				{
					dataFound = true;
					head = head.next;
				}
				else
				{
					Node<T> current = head;
					while (current.next != null)
					{
						if (current.next.data.Equals(data))
						{
							current.next = current.next.next;
							count--;
							dataFound = true;
						}
						current = current.next;
					}
					if (dataFound)
						Console.WriteLine ("Data Deleted");
					else
						Console.WriteLine ("Data not found");
				}
			}
			catch(Exception e){
				Console.WriteLine (e.Message);
			}
		}
		public void Find(T data)
		{
			try{
				bool dataFound = false;
				if (head == null) {
					Console.WriteLine ("Data not found");
					return;
				}
				if (head.data.Equals(data) )
				{
					dataFound = true;
				}
				else
				{
					Node<T> current = head;
					while (current.next != null)
					{
						if (current.next.data.Equals(data))
						{
							dataFound = true;
							break;
						}
						current = current.next;
					}
					if (dataFound)
						Console.WriteLine ("Data Found");
					else
						Console.WriteLine ("Data not found");
				}
			
			}
			catch(Exception e){
				Console.WriteLine (e.Message);
			}
		}
	}

	class Node<T>{
		public Node<T> next;
		public T data;
	}
}
