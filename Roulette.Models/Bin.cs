using System;

namespace Roulette.Models
{
    internal struct Bin
    {
        public int Number { get; }
        public ConsoleColor Color { get; }

        public Bin(int number, ConsoleColor color)
        {
            Number = number;
            Color = color;
        }

        public override string ToString() => 
            Number == 37 ? "00" : Number.ToString();
    }
}