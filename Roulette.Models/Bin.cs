using System;

namespace Roulette.Models
{
    public class Bin
    {
        public int Number { get; private set;}
        public ConsoleColor Color { get; private set;}
        public bool? IsEven { get; private set;}
        public bool? IsLow { get; private set;}
        public TriState Dozen { get; private set;}
        public TriState Column { get; private set;}

        public Bin(int number, ConsoleColor color)
        {
            Number = number;
            SetColor();
            if(number > 0 && number < 38)
            {
                IsEven = number % 2 == 0;
                IsLow = number < 19;
                SetDozen();
                SetColumn();
            }
        }

        public override string ToString() => 
            Number == 37 ? "00" : Number.ToString();

        private void SetColor()
        {
            var red = ConsoleColor.Red;
            var black = ConsoleColor.Black;
            var green = ConsoleColor.Green;

            switch (Number)
            {
                case 0: 
                    Color = green;
                    break;
                case int i when i >= 1 && i <=10:
                    Color = i % 2 == 0 ? black : red;
                    break;
                case int i when i >= 11 && i <=18:
                    Color = i % 2 != 0 ? black : red;
                    break;
                case int i when i >= 19 && i <=28:
                    Color = i % 2 == 0 ? black : red;
                    break;
                case int i when i >= 29 && i <=36:
                    Color = i % 2 != 0 ? black : red;
                    break;
                case 38:
                    Color = green; 
                    break;
            }
        }

        private void SetDozen()
        {
            switch (Number)
            {
                case int i when i > 0 && i <= 12:
                    Dozen = TriState.First;
                    break;
                case int i when i >= 13 && i <= 24:
                    Dozen = TriState.Second;
                    break;
                case int i when i >= 25 && i <= 37:
                    Dozen = TriState.Third;
                    break;
            }
        }
    }
}