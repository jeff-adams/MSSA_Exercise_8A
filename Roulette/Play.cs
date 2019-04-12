using System;
using System.Collections.Generic;
using System.Text;
using Roulette.Models;

namespace Roulette
{
    class Play
    {
        public void Run()
        {
            var croupier = new Croupier();
            var isPlaying = true;

            while (isPlaying)
            {
                var results = new string[11];
                Bin winningBin = croupier.SpinRouletteWheel();

                Console.Clear();
                PrintTable();
                results = FormatWinningBids(winningBin, croupier);

                
                
                Console.WriteLine($"Single: {winningBin}");
                Console.WriteLine($"Color: {winningBin.Color}");
                Console.WriteLine($"Even/Odd: {evenodd}");
                Console.WriteLine($"Low/High: {lowhigh}");
                Console.WriteLine($"Dozen: {ListOfBinsToString(croupier.WinningDozen)}");
                Console.WriteLine($"Column: {ListOfBinsToString(croupier.WinningColumn)}");
                Console.WriteLine($"Street: {ListOfBinsToString(croupier.WinningStreet)}");
                Console.WriteLine($"Double Streets: {ListOfBinsToString(croupier.WinningDoubleStreet)}");
                Console.WriteLine($"Split: {ListOfBinsToString(croupier.WinningSplits)}");
                Console.WriteLine($"Corners: {ListOfBinsToString(croupier.WinningCorner)}");

                Console.ReadKey(true);
            }
        }

        private string[] FormatWinningBids(Bin winningBin, Croupier croupier)
        {
            var results = new string[11];
            results[0] = winningBin.ToString();
            results[10] = "stats";

            if(winningBin.Number == 0 || winningBin.Number == 37)
            {
                for (int i = 1; i < results.Length - 1; i++)
                {
                    results[i] = "N/A";
                }   
            }
            else
            {
                string evenodd = (bool)winningBin.IsEven ? "Even" : "Odd";
                string lowhigh = (bool)winningBin.IsLow ? "Low" : "High";

                results[1] = winningBin.Color.ToString();
                results[2] = evenodd;
                results[3] = lowhigh;
                results[4] = ListOfBinsToString(croupier.WinningDozen);
                results[5] = ListOfBinsToString(croupier.WinningColumn);
                results[6] = ListOfBinsToString(croupier.WinningStreet);
                results[7] = ListOfBinsToString(croupier.WinningDoubleStreet);
                results[8] = ListOfBinsToString(croupier.WinningSplits);
                results[9] = ListOfBinsToString(croupier.WinningCorner);
                results[10] = croupier.Stats;
            }

            return results;
        }

        private void PrintTable()
        {
            var table = new string[]
            {
                "                                                                       ",
                "   ╭─────────────────────────────────────────────────────────────╮     ",
                "   │                     Let's Play Roulette!                    │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │         Single                                              │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │          Color                                              │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │       Even/Odd                                              │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │       Low/High                                              │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │          Dozen                                              │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │         Column                                              │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │         Street                                              │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │ Double Streets                                              │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │          Split                                              │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │        Corners                                              │     ",
                "   ├─────────────────────────────────────────────────────────────┤     ",
                "   │          Stats                                              │     ",
                "   ╰─────────────────────────────────────────────────────────────╯     ",
                "                       Press ENTER to play again                       ",
            };

            foreach (var line in table)
            {
                Console.WriteLine(line);
            }
        }

        private string ListOfBinsToString(List<Bin> winningBins)
        {
            var sb = new StringBuilder();
            foreach (var bin in winningBins)
            {
                sb.Append($"{bin} ");
            }
            
            return sb.ToString();
        }
    }
}