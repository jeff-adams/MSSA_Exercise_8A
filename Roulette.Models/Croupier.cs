using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roulette.Models
{
    public class Croupier
    {
        private Roulette roulette;
        private Bin winningBin;
        private Win winnerWinnerChickenDinner;

        private Dictionary<int, int> rolledBins;
        private int totalSpins;
        private int totalBlack;
        private int totalRed;

        public List<Bin> WinningDozen => roulette.Table.Where(bin => bin.Dozen == winningBin.Dozen).ToList();
        public List<Bin> WinningColumn => roulette.Table.Where(bin => bin.Column == winningBin.Dozen).ToList();
        public List<Bin> WinningStreet => roulette.Table.Where(bin => bin.Street == winningBin.Street).ToList();
        public List<Bin> WinningSplits => winnerWinnerChickenDinner.Split(winningBin);
        public List<Bin> WinningDoubleStreet => winnerWinnerChickenDinner.DoubleStreet(winningBin);
        public List<Bin> WinningCorner => winnerWinnerChickenDinner.Corner(winningBin);
        public string Stats {get; private set;}

        public Croupier()
        {
            roulette = new Roulette();
            rolledBins = new Dictionary<int, int>();
            winnerWinnerChickenDinner = new Win(roulette);
            Stats = "No statistics tracked";
        }

        public Bin SpinRouletteWheel()
        {
            winningBin = roulette.Wheel[new Random().Next(0,38)];
            return winningBin;
        }

        public Bin SpinRouletteWheel(int seed)
        {
            winningBin = roulette.Wheel[new Random(seed).Next(0,38)];
            return winningBin;
        }

        private void AddToStatistics()
        {
            if (rolledBins.ContainsKey(winningBin.Number))
            {
                rolledBins[winningBin.Number]++;
            }
            else
            {
                rolledBins.Add(winningBin.Number, 1);
            }

            var sb = new StringBuilder();
            sb.Append("Total spins calculated ")
              .Append($"{totalSpins} | ")
              .Append("Bin that has appeared the most ")
              .Append("");//search dictionary for largest value
        }
    }
}