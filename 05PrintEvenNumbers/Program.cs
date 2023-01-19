using System;
using System.Collections.Generic;
using System.Linq;

namespace _05PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numbs.Count; i++)
            {
                if (numbs[i] % 2 == 0)
                {
                    queue.Enqueue(numbs[i]);
                }
            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
