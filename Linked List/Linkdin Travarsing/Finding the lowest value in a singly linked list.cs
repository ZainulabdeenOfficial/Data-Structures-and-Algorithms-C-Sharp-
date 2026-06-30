using System;

class Node {
	 public int data ;
	public Node next ;
	 public Node (int Data)
	 {
		 data = Data;
		 next = null;
	 }
	
	public int  findmidvalue (Node head)
	{
	   int   minValue = head.data;
    Node currentNode = head.next;
		
		while (currentNode != null )
		{
			if (currentNode.data < minValue)
			{
				 minValue = currentNode.data;
       
         
			}
			 currentNode = currentNode.next;
			
		}
		 return minValue;
		
		
	}
	
	
	
	
}
					
public class Program
{
	public static void Main()
	{
Node node1 =  new Node(7);
Node   node2 = new Node(11);
Node   node3 = new Node(3);
Node   node4 =new  Node(2);
Node   node5 =new   Node(9);

node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node5;
		
Console.WriteLine("The lowest value in the linked list is: " + node1.findmidvalue(node1));
		
	}
}