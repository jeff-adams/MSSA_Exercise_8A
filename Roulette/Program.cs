using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;

            new Play().Run();

            Console.CursorVisible = true;
        }
    }
}
