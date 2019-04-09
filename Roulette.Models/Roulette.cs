using System;

namespace Roulette.Models
{
    class Roulette
    {
        internal Bin[] Wheel { get; private set;}

        public Roulette()
        {
            Wheel = new Bin[38];
            CreateRouletteWheel();
        }

        private void CreateRouletteWheel()
        {
            var Bins = new Bin[38];

            for (int i = 0; i < Wheel.Length; i++)
            {
                Bins[i] = CreateBin(i);
            }

            OrderBinsOnAmericanWheel(Bins);
        }

        private Bin CreateBin(int binNumber)
        {
            var bin = new Bin();
            var red = ConsoleColor.Red;
            var black = ConsoleColor.Black;
            var green = ConsoleColor.Green;

            switch (binNumber)
            {
                case 0: 
                    bin = new Bin(binNumber, green);
                    break;
                case int i when i >= 1 && i <=10:
                    bin = i % 2 == 0 ? new Bin(i, black) : new Bin(i, red);
                    break;
                case int i when i >= 11 && i <=18:
                    bin = i % 2 != 0 ? new Bin(i, black) : new Bin(i, red);
                    break;
                case int i when i >= 19 && i <=28:
                    bin = i % 2 == 0 ? new Bin(i, black) : new Bin(i, red);
                    break;
                case int i when i >= 29 && i <=36:
                    bin = i % 2 != 0 ? new Bin(i, black) : new Bin(i, red);
                    break;
                case 38:
                    bin = new Bin(binNumber, green); 
                    break;
            }

            return bin;
        }

        private void OrderBinsOnAmericanWheel(Bin[] bins)
        {
            Wheel[0] = bins[0];
            Wheel[1] = bins[28];
            Wheel[2] = bins[9];
            Wheel[3] = bins[26];
            Wheel[4] = bins[30];
            Wheel[5] = bins[11];
            Wheel[6] = bins[7];
            Wheel[7] = bins[20];
            Wheel[8] = bins[32];
            Wheel[9] = bins[17];
            Wheel[10] = bins[5];
            Wheel[11] = bins[22];
            Wheel[12] = bins[34];
            Wheel[13] = bins[15];
            Wheel[14] = bins[3];
            Wheel[15] = bins[24];
            Wheel[16] = bins[36];
            Wheel[17] = bins[13];
            Wheel[18] = bins[1];
            Wheel[19] = bins[3];
            Wheel[20] = bins[27];
            Wheel[21] = bins[10];
            Wheel[22] = bins[25];
            Wheel[23] = bins[29];
            Wheel[24] = bins[12];
            Wheel[25] = bins[8];
            Wheel[26] = bins[19];
            Wheel[27] = bins[31];
            Wheel[28] = bins[18];
            Wheel[29] = bins[6];
            Wheel[30] = bins[21];
            Wheel[31] = bins[33];
            Wheel[32] = bins[16];
            Wheel[33] = bins[4];
            Wheel[34] = bins[23];
            Wheel[35] = bins[35];
            Wheel[36] = bins[14];
            Wheel[37] = bins[2];
        }
    }
}