using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string command = "";

            while ((command = Console.ReadLine()) != "END")
            {
                var elements = command.Split();

                switch (elements[0])
                {
                    case "Create":
                        List<string> items = new List<string>();
                        items.AddRange(elements.Skip(1));
                        listyIterator = new ListyIterator<string>(items);
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "PrintAll":
                        foreach (var item in listyIterator)
                        {
                            Console.Write(item + " ");
                        }
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
