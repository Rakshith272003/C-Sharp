using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> q = new Queue<string>();

        // Enqueue
        q.Enqueue("One");
        q.Enqueue("Two");
        q.Enqueue("Three");

        // Peek
        Console.WriteLine("Peek: " + q.Peek()); // One

        // Contains
        Console.WriteLine("Contains 'Two'? " + q.Contains("Two")); // True

        // Count
        Console.WriteLine("Count: " + q.Count); // 3

        // Dequeue
        Console.WriteLine("Removed: " + q.Dequeue()); // One
        Console.WriteLine("After Clear, Count: " + q.Count); 

        Console.WriteLine("Removed: " + q.Dequeue());

        Console.WriteLine("After Clear, Count: " + q.Count); 

        //// ToArray
        //string[] arr = q.ToArray();
        //Console.WriteLine("Array: " + string.Join(", ", arr)); // Two, Three

        // Clear
        q.Clear();

        Console.WriteLine("After Clear, Count: " + q.Count); // 0

        


    }
}
