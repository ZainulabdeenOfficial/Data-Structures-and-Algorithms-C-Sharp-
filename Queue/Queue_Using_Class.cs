using System;
using System.Collections.Generic;
					
public class Program
{
	class Queue{
	private List<string> queue = new List<string>();
	
	public void equeue(string element)
	{

		queue.Add(element);
		
	}
	
	public bool isempty()
	{
		return queue.Count == 0;
	}
	
	public string dequeue()
	{
		if (isempty())
		{
			Console.WriteLine("Queue is empty");
			
		}
		string front = queue[0];
			queue.RemoveAt(0);
			return front;
	}
	public string peak()
	{
		if (isempty())
		{
			Console.WriteLine("Queue is empty");
			
		}
		
		return queue[0];
	}
	
	public int size()
	{
	
		if (isempty())
		{
			Console.WriteLine("Queue is empty");
			
		}
		
		return queue.Count;
		
	}
	 public void Display()
    {
        Console.Write("Queue: ");
        foreach (string item in queue)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

	}
	
	public static void Main()
	{
		
     Queue  myQueue = new Queue();

        myQueue.equeue("A");
        myQueue.equeue("B");
        myQueue.equeue("C");

        myQueue.Display();

        Console.WriteLine("Dequeue: " + myQueue.dequeue());
        Console.WriteLine("Peek: " + myQueue.peak());
        Console.WriteLine("Is Empty: " + myQueue.isempty());
        Console.WriteLine("Size: " + myQueue.size());
	}
}