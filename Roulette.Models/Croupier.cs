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

        private Bin SpinRouletteWheel() => roulette.Wheel[new Random().Next(0,37)];

        private List<string> CreateWinningBets()
        {
            var winningBets = new List<string>();

            return winningBets;
        }

    }
}