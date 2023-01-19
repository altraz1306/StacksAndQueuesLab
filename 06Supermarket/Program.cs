using System;
using System.Collections.Generic;

namespace _06Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cmds = Console.ReadLine();

            var queue = new Queue<string>();


            while (cmds != "End")
            {
                
                if (cmds != "Paid")
                {
                  queue.Enqueue(cmds);
                }
                else if (cmds == "Paid")
                {
                    for (int i = queue.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
               
                cmds = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
