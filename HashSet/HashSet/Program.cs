using System;
using System.Collections.Generic;

namespace SimpleHashSetDemo
{
    class Program
    {
        static void Main()
        {
            HashSet<string> set1 = new HashSet<string>() { "apple", "banana", "cherry" };
            HashSet<string> set2 = new HashSet<string>() { "banana", "cherry", "dates" };

            Console.WriteLine("--- Original Set1 ---");
            Print(set1);

            // Add
            set1.Add("mango");

            // Contains
            Console.WriteLine("Contains 'banana'? " + set1.Contains("banana"));

            // Remove
            set1.Remove("apple");

            // UnionWith
            set1.UnionWith(set2);
            Console.WriteLine("\nAfter UnionWith:");
            Print(set1);

            // IntersectWith
            set1.IntersectWith(set2);
            Console.WriteLine("\nAfter IntersectWith:");
            Print(set1);

            // ExceptWith
            set1.ExceptWith(new HashSet<string>() { "banana" });
            Console.WriteLine("\nAfter ExceptWith:");
            Print(set1);

            // SymmetricExceptWith
            HashSet<string> a = new HashSet<string>() { "a", "b", "c" };
            HashSet<string> b = new HashSet<string>() { "b", "c", "d" };
            a.SymmetricExceptWith(b);
            Console.WriteLine("\nSymmetric Difference of a and b:");
            Print(a);

            // SetEquals
            HashSet<int> x = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> y = new HashSet<int>() { 3, 2, 1 };
            Console.WriteLine("\nSetEquals: " + x.SetEquals(y)); // true
        }

        static void Print(HashSet<string> set)
        {
            foreach (var item in set)
                Console.WriteLine(item);
        }
    }
}
