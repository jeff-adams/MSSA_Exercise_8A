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
                splits.Add(roulette.Table[winningBin.Number - 3]);
            }
            if(winningBin.Street != 12)
            {
                splits.Add(roulette.Table[winningBin.Number + 3]);
            }
            if(winningBin.Column != 1)
            {
                splits.Add(roulette.Table[winningBin.Number - 1]);
            }
            if(winningBin.Column != 3)
            {
                splits.Add(roulette.Table[winningBin.Number + 1]);
            }

            return splits;
        }

        public List<Bin> DoubleStreet(Bin winningBin)
        {
            var doubleStreets = new List<Bin>();

            foreach (var bin in roulette.Table)
            {
                if (winningBin.Street != 1)
                {
                    if(bin.Street == winningBin.Street - 1)
                    {
                        doubleStreets.Add(bin);
                    }
                }
                if(bin.Street == winningBin.Street)
                {
                    doubleStreets.Add(bin);
                }
                if(winningBin.Street != 12)
                {
                    if(bin.Street == winningBin.Street + 1)
                    {
                        doubleStreets.Add(bin);
                    }
                }
            }

            return doubleStreets;
        }

        public List<Bin> Corner(Bin winningBin)
        {
            var corner = new List<Bin>();

            if (winningBin.Column < 3 && winningBin.Street > 1)
            {
                corner.AddRange(NECorner(winningBin));
            }

            if (winningBin.Column < 3 && winningBin.Street < 12)
            {
                corner.AddRange(SECorner(winningBin));
            }
            
            if (winningBin.Column > 1 && winningBin.Street < 12)
            {
                corner.AddRange(SWCorner(winningBin));
            }
            if(winningBin.Column > 1 && winningBin.Street > 1)
            {
                corner.AddRange(NWCorner(winningBin));
            }

            return corner;
        }

        private List<Bin> NECorner(Bin winningBin)
        {
            var corner = new List<Bin>();

            corner.Add(roulette.Table[winningBin.Number - 3]);
            corner.Add(roulette.Table[winningBin.Number - 2]);
            corner.Add(winningBin);
            corner.Add(roulette.Table[winningBin.Number + 1]);

            return corner;
        }

        private List<Bin> SECorner(Bin winningBin)
        {
            var corner = new List<Bin>();

            corner.Add(winningBin);
            corner.Add(roulette.Table[winningBin.Number + 1]);
            corner.Add(roulette.Table[winningBin.Number + 3]);
            corner.Add(roulette.Table[winningBin.Number + 4]);

            return corner;
        }

        private List<Bin> SWCorner(Bin winningBin)
        {
            var corner = new List<Bin>();

            corner.Add(roulette.Table[winningBin.Number - 1]);
            corner.Add(winningBin);
            corner.Add(roulette.Table[winningBin.Number + 2]);
            corner.Add(roulette.Table[winningBin.Number + 3]);

            return corner;
        }

        private List<Bin> NWCorner(Bin winningBin)
        {
            var corner = new List<Bin>();

            corner.Add(roulette.Table[winningBin.Number - 4]);
            corner.Add(roulette.Table[winningBin.Number - 3]);
            corner.Add(roulette.Table[winningBin.Number - 1]);
            corner.Add(winningBin);

            return corner;
        }
    }
}