using System;
using System.Collections.Generic;
using System.Linq;

namespace _03SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chars = new List<string>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList());
            var stack = new Stack<string>(chars);

            while (stack.Any())
            {

            }
        }
    }
}
