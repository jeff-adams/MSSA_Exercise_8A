using System;
using System.Collections.Generic;
using System.Text;
using Roulette.Models;

namespace Roulette
{
    class Play
    {
        private int x;
        private int y;

        public void Run()
        {
            var croupier = new Croupier();
            var isPlaying = true;

            while (isPlaying)
            {
                var results = new string[11];
                Bin winningBin = croupier.SpinRouletteWheel();

                Console.Clear();
                Console.CursorVisible = false;

                PrintTable();

                results = FormatWinningBids(winningBin, croupier);
                PrintResults(results);

                var input = Console.ReadKey(true);
                isPlaying = !(input.Key == ConsoleKey.Q);
            }
        }

        private void PrintResults(string[] results)
        {
            var offsetX = 21;
            var offsetY = 3;
            var incrementY = 2;

            for (int i = 0; i < results.Length; i++)
            {
                Console.SetCursorPosition(x + offsetX, y + offsetY + (incrementY * i));
                Console.Write(results[i]);
            }
        }

        private string[] FormatWinningBids(Bin winningBin, Croupier croupier)
        {
            var results = new string[11];
            results[0] = winningBin.ToString();
            results[10] = croupier.Stats;

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
            }

            return results;
        }

        private void PrintTable()
        {
            var table = new string[]
            {
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

            x = Console.WindowWidth / 2 - table[0].Length / 2;
            y = Console.WindowHeight / 2 - table.Length / 2;


            for(int i = 0; i < table.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(table[i]);
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