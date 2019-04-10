using System;
using System.Collections.Generic;

namespace Roulette.Models
{
    public class Croupier
    {
        private Roulette roulette;
        private Bin winningBin;

        public Croupier()
        {
            roulette = new Roulette();
        }

        public void SpinRouletteWheel()
        {
            winningBin = roulette.Wheel[new Random().Next(0,38)];
        }

    }
}