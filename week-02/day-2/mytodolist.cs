using System;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            todoText = todoText.Insert(0, "My todo:\n");
            todoText = todoText.Insert(todoText.Length, " - Download games\n");
            todoText = todoText.Insert(todoText.Length, "   - Diablo");
            Console.WriteLine(todoText);
            Console.ReadLine();

        }
    }
}
