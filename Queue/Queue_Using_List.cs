using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		  Queue<string> queue = new Queue<string>();
		queue.Enqueue("A");
		queue.Enqueue("B");
		queue.Enqueue("C");
		queue.Enqueue("D");
		queue.Enqueue("Zain");
		 Console.WriteLine("Queue: " + string.Join(", ", queue));
		
		string deque_element = queue.Dequeue();
		Console.WriteLine("DeQueue Value is"+deque_element);
		
		Console.WriteLine("Peak Value is "+ queue.Peek());
		
		 Console.WriteLine("isEmpty: " + (queue.Count == 0));
		  Console.WriteLine("Size: " + queue.Count);
		
		
		
		
		
		
	}
}