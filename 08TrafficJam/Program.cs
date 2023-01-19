using System;
using System.Collections.Generic;

namespace _08TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var command = Console.ReadLine();
            var count = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < cars; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        count++;
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
