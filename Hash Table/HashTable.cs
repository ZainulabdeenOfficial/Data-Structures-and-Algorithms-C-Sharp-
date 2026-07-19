using System;
using System.Collections.Generic;

public class Program
{
    static List<string>[] myHashSet =
    {
        new List<string>(),
        new List<string> { "Jones" },
        new List<string>(),
        new List<string> { "Lisa" },
        new List<string>(),
        new List<string> { "Bob" },
        new List<string>(),
        new List<string> { "Siri" },
        new List<string> { "Pete" },
        new List<string>()
    };

    static int HashFunction(string value)
    {
        int sum = 0;

        foreach (char c in value)
        {
            sum += c;
        }

        return sum % 10;
    }

    static void Add(string value)
    {
        int index = HashFunction(value);

        if (!myHashSet[index].Contains(value))
        {
            myHashSet[index].Add(value);
        }
    }

    static bool Contains(string value)
    {
        int index = HashFunction(value);
        return myHashSet[index].Contains(value);
    }

    public static void Main()
    {
        Add("Stuart");

        for (int i = 0; i < myHashSet.Length; i++)
        {
            Console.Write("Bucket " + i + ": ");

            if (myHashSet[i].Count == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine(string.Join(", ", myHashSet[i]));
            }
        }

        Console.WriteLine("Contains Stuart: " + Contains("Stuart"));
    }
}