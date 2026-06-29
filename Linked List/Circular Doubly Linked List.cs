using System;
class Node {
	 public int data ;
 public Node Next;
public Node prev;
	public Node(int Data)
	{
		data = Data;
		Next = null;
		prev = null;
	}
}
					
public class Program
{
	public static void Main()
	{
	Node 	node1 = new  Node(3);
Node node2 =  new Node(5);
Node node3 = new  Node(13);
Node node4 = new  Node(2);
		
node1.Next = node2;
node1.prev = node4;

node2.prev = node1;
node2.Next = node3;

node3.prev = node2;
node3.Next = node4;

node4.prev = node3;
node4.Next = node1;
		
Node currentNode = node4;
Node startNode = node4;
Console.Write(currentNode.data + " -> ");
currentNode = currentNode.prev;

while (currentNode != startNode)
{
    Console.Write(currentNode.data + " -> ");
    currentNode = currentNode.prev;
}

Console.WriteLine("...");
}
}