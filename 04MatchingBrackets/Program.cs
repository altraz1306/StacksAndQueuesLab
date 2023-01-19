using System;
using System.Collections.Generic;

namespace _04MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var index = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                  index.Push(i);
                }
                if (input[i] == ')')
                {
                   var brackets = index.Pop();

                    for (int j = brackets; j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }

                    Console.WriteLine();
                }
                
            }
        }
    }
}
