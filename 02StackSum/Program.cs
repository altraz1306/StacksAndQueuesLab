using System;
using System.Linq;
using System.Collections.Generic;

namespace _02StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var stack = new Stack<int>(input);

            var command = Console.ReadLine()
                .ToLower();

            while (command != "end")
            {
                string[] cmds = command.Split();
                
                if (cmds[0] == "add")
                {
                    stack.Push(int.Parse(cmds[1]));
                    stack.Push(int.Parse(cmds[2]));
                }
                if (cmds[0] == "remove")
                {
                    var n = int.Parse(cmds[1]);
                    if (n <= stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }
                command = Console.ReadLine()
                .ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");


        }
    }
}
