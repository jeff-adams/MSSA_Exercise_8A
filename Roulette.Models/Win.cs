using System;
using System.Collections.Generic;

namespace Roulette.Models
{
    public class Win
    {
        private Roulette roulette;

        public Win(Roulette roulette)
        {
            this.roulette = roulette;
        }
        public List<Bin> Split(Bin winningBin)
        {
            var splits = new List<Bin>();

            if(winningBin.Street != 1)
            {
                splits.Add(roulette.Wheel[winningBin.Number - 4]);
            }
            if(winningBin.Street != 12)
            {
                splits.Add(roulette.Wheel[winningBin.Number + 4]);
            }
            if(winningBin.Column != 1)
            {
                splits.Add(roulette.Wheel[winningBin.Number - 1]);
            }
            if(winningBin.Column != 3)
            {
                splits.Add(roulette.Wheel[winningBin.Number + 1]);
            }

            return splits;
        }

    }
}