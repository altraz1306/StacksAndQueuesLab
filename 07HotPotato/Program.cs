using System;
using System.Collections.Generic;
using System.Linq;

namespace _07HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var countOfRolls = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(children);
            var rollses = 1;
            while (queue.Count != 1)
            {
                var child = queue.Dequeue();
                if (rollses < countOfRolls)
                {
                    rollses++;
                    queue.Enqueue(child);
                }
                else
                {
                    Console.WriteLine($"Removed {child}");
                    rollses = 1;
                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
