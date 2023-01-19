using System;
using System.Collections.Generic;

namespace _01ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chars = new Stack<char>();
            var words = Console.ReadLine();

            foreach (var item in words)
            {
                chars.Push(item);
            }
            while (chars.Count != 0)
            {
                Console.Write(chars.Pop());
            }
        }
    }
}
