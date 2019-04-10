using System;

namespace Roulette.Models
{
    public class Bin
    {
        public int Number { get; private set;}
        public ConsoleColor Color { get; private set;}
        public bool? IsEven { get; private set;}
        public bool? IsLow { get; private set;}
        public int Dozen { get; private set;}
        public int Column { get; private set;}
        public int Street { get; private set;} 

        public Bin(int number)
        {
            Number = number;
            SetColor();
            if(number > 0 && number < 38)
            {
                IsEven = number % 2 == 0;
                IsLow = number < 19;
                SetDozen();
                SetColumn();
                SetStreet();
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
                case int i when i >= 1 && i <= 12:
                    Dozen = 1;
                    break;
                case int i when i >= 13 && i <= 24:
                    Dozen = 2;
                    break;
                case int i when i >= 25 && i <= 36:
                    Dozen = 3;
                    break;
            }
        }

        private void SetColumn()
        {
            int columnValue = Number % 3;
            Column = columnValue > 0 ? columnValue : 3;
        }

        private void SetStreet()
        {
            Street = ((Number - 1) / 3) + 1;
        }
    }
}