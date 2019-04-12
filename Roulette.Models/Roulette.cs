using System;

namespace Roulette.Models
{
    public class Roulette
    {
        public Bin[] Wheel { get; private set;}
        public Bin[] Table { get; private set;}

        public Roulette()
        {
            Wheel = new Bin[38];
            Table = new Bin[38];
            
            CreateRouletteWheel();
        }

        private void CreateRouletteWheel()
        {
            for (int i = 0; i < Wheel.Length; i++)
            {
                Table[i] = new Bin(i);
            }

            OrderBinsOnAmericanWheel();
        }

        private void OrderBinsOnAmericanWheel()
        {
            Wheel[0] = Table[0];
            Wheel[1] = Table[28];
            Wheel[2] = Table[9];
            Wheel[3] = Table[26];
            Wheel[4] = Table[30];
            Wheel[5] = Table[11];
            Wheel[6] = Table[7];
            Wheel[7] = Table[20];
            Wheel[8] = Table[32];
            Wheel[9] = Table[17];
            Wheel[10] = Table[5];
            Wheel[11] = Table[22];
            Wheel[12] = Table[34];
            Wheel[13] = Table[15];
            Wheel[14] = Table[3];
            Wheel[15] = Table[24];
            Wheel[16] = Table[36];
            Wheel[17] = Table[13];
            Wheel[18] = Table[1];
            Wheel[19] = Table[3];
            Wheel[20] = Table[27];
            Wheel[21] = Table[10];
            Wheel[22] = Table[25];
            Wheel[23] = Table[29];
            Wheel[24] = Table[12];
            Wheel[25] = Table[8];
            Wheel[26] = Table[19];
            Wheel[27] = Table[31];
            Wheel[28] = Table[18];
            Wheel[29] = Table[6];
            Wheel[30] = Table[21];
            Wheel[31] = Table[33];
            Wheel[32] = Table[16];
            Wheel[33] = Table[4];
            Wheel[34] = Table[23];
            Wheel[35] = Table[35];
            Wheel[36] = Table[14];
            Wheel[37] = Table[2];
        }
    }
}