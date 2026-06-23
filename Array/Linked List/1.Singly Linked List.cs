using System;
class Node {
			public int Data ;
			public Node Next ;
		
		
		public Node (int data)
		{
			Data = data;
			Next = null;
		}
			
		}					
public class Program
{
	public static void Main()
	{
		Node node1 = new Node(3);
        Node node2 = new Node(5);
        Node node3 = new Node(13);
        Node node4 = new Node(2);

        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node4;

        Node currentNode = node1;
		
		while (currentNode != null)
        {
            Console.Write(currentNode.Data + " -> ");
            currentNode = currentNode.Next;
        }

        Console.WriteLine("null");
		
	}
}