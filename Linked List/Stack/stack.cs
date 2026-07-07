using System;
using System.Collections.Generic;	
public class Program
{
	public static void Main()
	{
		  Stack<char> stack = new Stack<char>();
		stack.Push('A');
     stack.Push('B');
      stack.Push('C');
		foreach(char item in stack)
		{

			Console.WriteLine(item);
		}
		
		Console.WriteLine("Top Value"+stack.Peek());
		
		Console.WriteLine("pop Value"+stack.Pop());
		
		if (stack.Count==0)
		{
			Console.WriteLine("Stack is empty");
		}
		
		Console.WriteLine("Size of stack"+stack.Count);
		
			
	
		
	}
}