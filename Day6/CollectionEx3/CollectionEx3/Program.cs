using System;

namespace CollectionEx3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Implement stack and Queue using array as backing field in the class
			MyStack stack = new MyStack();
			stack.push (1);
			stack.push (2);
			stack.push (3);
			stack.push (4);
			Console.WriteLine ("The top element is " + stack.peek ());
			Console.WriteLine ("The popped element is " + stack.pop ());
			Console.WriteLine ("The popped element is " + stack.pop ());
			Console.WriteLine ("The top element is " + stack.peek ());
			MyQueue queue = new MyQueue();
			queue.enqueue (1);
			queue.enqueue (2);
			queue.enqueue (3);
			queue.enqueue (4);

			Console.WriteLine ("The dequeued element is " + queue.dequeue ());
			Console.WriteLine ("The dequeued element is " + queue.dequeue ());

		}
	}
	class MyStack{
		int[] dataArray = new int[10];
		int top=-1;
		public void push(int ele){
			top++;
			if (top < dataArray.Length) {
				dataArray [top] = ele;
				Console.WriteLine (ele + "pushed to stack");
			} else {
				Console.WriteLine ("Stack OverFlow");
			}
		}
		public int pop(){
			top--;
			if (top >=0) {
				return dataArray [top];
			} else {
				
				Console.WriteLine ("Stack UnderFlow");
				return -1;
			}
		}
		public int peek(){
			
			if (top >=0) {
				return dataArray [top];
			} else {
				Console.WriteLine ("No elements");
				return -1;
			}
		}
	}
	class MyQueue{
		int[] dataArray = new int[10];
		int front=-1;
		int rear=-1;
		public void enqueue(int ele){
			rear++;
			if (rear < dataArray.Length) {
				dataArray [rear] = ele;
				Console.WriteLine (ele + "enqueued to queue");
			} else {
				Console.WriteLine ("Queue OverFlow");
			}
		}
		public int dequeue(){
			front++;
			if (front < dataArray.Length) {
				return dataArray [front];
			} else {
				Console.WriteLine ("Queue UnderFlow");
				return -1;
			}
		}

	}
}
