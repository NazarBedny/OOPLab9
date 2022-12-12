using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var element = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (element[0])
                {
                    case "Push":
                        var a = element.Skip(1)
                            .Select(i => i.Split(',').First())
                            .Select(int.Parse)
                            .ToList();
                        stack.Push(a);
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

