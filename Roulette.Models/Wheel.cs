using System;

namespace Roulette.Models
{
    public class Wheel
    {
        public Bin[] RouletteWheel { get; private set;}

        public Wheel()
        {
            RouletteWheel = new Bin[38];
            CreateRouletteWheel();
        }

        private void CreateRouletteWheel()
        {
            var Bins = new Bin[38];

            for (int i = 0; i < RouletteWheel.Length; i++)
            {
                Bins[i] = CreateBin(i);
            }

            OrderBinsOnAmericanWheel(Bins);
        }

        private Bin CreateBin(int binNumber)
        {
            Bin bin = new Bin();
            var red = ConsoleColor.Red;
            var black = ConsoleColor.Black;
            var green = ConsoleColor.Green;

            switch (binNumber)
            {
                case 0: 
                    bin = new Bin(binNumber, green);
                    break;
                case int i when i >= 1 && i <=10:
                    bin = i % 2 == 0 ? new Bin(i, black) : new Bin (i, red);
                    break;
                case int i when i >= 11 && i <=18:
                    bin = i % 2 != 0 ? new Bin(i, black) : new Bin (i, red);
                    break;
                case int i when i >= 19 && i <=28:
                    bin = i % 2 == 0 ? new Bin(i, black) : new Bin (i, red);
                    break;
                case int i when i >= 29 && i <=36:
                    bin = i % 2 != 0 ? new Bin(i, black) : new Bin (i, red);
                    break;
                case 38:
                    bin = new Bin(binNumber, green); 
                    break;
            }

            return bin;
        }

        private void OrderBinsOnAmericanWheel(Bin[] bins)
        {
            RouletteWheel[0] = bins[0];
            RouletteWheel[1] = bins[28];
            RouletteWheel[2] = bins[9];
            RouletteWheel[3] = bins[26];
            RouletteWheel[4] = bins[30];
            RouletteWheel[5] = bins[11];
            RouletteWheel[6] = bins[7];
            RouletteWheel[7] = bins[20];
            RouletteWheel[8] = bins[32];
            RouletteWheel[9] = bins[17];
            RouletteWheel[10] = bins[5];
            RouletteWheel[11] = bins[22];
            RouletteWheel[12] = bins[34];
            RouletteWheel[13] = bins[15];
            RouletteWheel[14] = bins[3];
            RouletteWheel[15] = bins[24];
            RouletteWheel[16] = bins[36];
            RouletteWheel[17] = bins[13];
            RouletteWheel[18] = bins[1];
            RouletteWheel[19] = bins[3];
            RouletteWheel[20] = bins[27];
            RouletteWheel[21] = bins[10];
            RouletteWheel[22] = bins[25];
            RouletteWheel[23] = bins[29];
            RouletteWheel[24] = bins[12];
            RouletteWheel[25] = bins[8];
            RouletteWheel[26] = bins[19];
            RouletteWheel[27] = bins[31];
            RouletteWheel[28] = bins[18];
            RouletteWheel[29] = bins[6];
            RouletteWheel[30] = bins[21];
            RouletteWheel[31] = bins[33];
            RouletteWheel[32] = bins[16];
            RouletteWheel[33] = bins[4];
            RouletteWheel[34] = bins[23];
            RouletteWheel[35] = bins[35];
            RouletteWheel[36] = bins[14];
            RouletteWheel[37] = bins[2];
        }
    }
}