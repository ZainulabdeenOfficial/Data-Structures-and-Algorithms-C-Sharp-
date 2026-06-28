using System;
class Node{
	public int data ;
	public Node next;
	public Node prev;
	
	public Node (int Data)
	{
      data = Data;
		next = null;
		prev = null;
	}
	
}
					
public class Program
{
	public static void Main()
	{
	Node	node1 =  new Node(3);
    Node  node2 =  new Node(5);
   Node node3 =  new Node(13);
   Node  node4 =  new Node(2);
	
node1.next = node2;

node2.prev = node1;
node2.next = node3;

node3.prev = node2;
node3.next = node4;

node4.prev = node3;
Node CorrectNode = node1;
		
	while (CorrectNode != null)
        {
            Console.Write(CorrectNode.data + " -> ");
		    CorrectNode = CorrectNode.next;

            
        }

        Console.WriteLine("null");


	}
}