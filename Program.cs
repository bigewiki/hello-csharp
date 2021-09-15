using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# from Ubuntu!");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {}
        }
    }
}
