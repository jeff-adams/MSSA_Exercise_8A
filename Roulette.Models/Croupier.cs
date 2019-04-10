using System;
using System.Collections.Generic;

namespace Roulette.Models
{
    public class Croupier
    {
        private Roulette roulette;
        private Bin winningBin;
        private Win winnerWinnerChickenDinner;

        public Croupier()
        {
            roulette = new Roulette();
            winnerWinnerChickenDinner = new Win(roulette);
        }

        public void SpinRouletteWheel()
        {
            winningBin = roulette.Wheel[new Random().Next(0,38)];
        }

        public void SpinRouletteWheel(int seed)
        {
            winningBin = roulette.Wheel[new Random(seed).Next(0,38)];
        }
    }
}