using System;

class Node
{
    public string Data;
    public Node Next;

    public Node(string data)
    {
        Data = data;
        Next = null;
    }
}

class Queue
{
    private Node front;
    private Node rear;
    private int length;

    public Queue()
    {
        front = null;
        rear = null;
        length = 0;
    }

    public void Enqueue(string element)
    {
        Node newNode = new Node(element);

        if (rear == null)
        {
            front = rear = newNode;
            length++;
            return;
        }

        rear.Next = newNode;
        rear = newNode;
        length++;
    }

    public string Dequeue()
    {
        if (IsEmpty())
            return "Queue is empty";

        Node temp = front;
        front = front.Next;
        length--;

        if (front == null)
            rear = null;

        return temp.Data;
    }

    public string Peek()
    {
        if (IsEmpty())
            return "Queue is empty";

        return front.Data;
    }

    public bool IsEmpty()
    {
        return length == 0;
    }

    public int Size()
    {
        return length;
    }

    public void PrintQueue()
    {
        Node temp = front;

        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue myQueue = new Queue();

        myQueue.Enqueue("A");
        myQueue.Enqueue("B");
        myQueue.Enqueue("C");

        Console.Write("Queue: ");
        myQueue.PrintQueue();

        Console.WriteLine("Dequeue: " + myQueue.Dequeue());

        Console.WriteLine("Peek: " + myQueue.Peek());

        Console.WriteLine("IsEmpty: " + myQueue.IsEmpty());

        Console.WriteLine("Size: " + myQueue.Size());
    }
}