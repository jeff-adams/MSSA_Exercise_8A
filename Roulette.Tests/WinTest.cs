using System;
using System.Collections.Generic;
using Xunit;
using Roulette.Models;

namespace Roulette.Tests
{
    public class WinTest
    {
        [Theory]
        [MemberData(nameof(SplitTestData))]
        public void SplitTest(Bin winningBin, List<Bin> expected)
        {
            var roulette = new Models.Roulette();
            var win = new Win(roulette);
            var actual = win.Split(winningBin);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.Equal(actual[i].Number, expected[i].Number);   
            }
        }

        public static IEnumerable<object[]> SplitTestData
        {
            get
            {
                return new[]
                {
                    new object[] 
                    { 
                        new Bin(1),
                        new List<Bin>
                        {
                            new Bin(4),
                            new Bin(2),
                        }            
                    },
                    new object[]
                    {
                        new Bin(3),
                        new List<Bin>
                        {
                            new Bin(6),
                            new Bin(2),
                        }
                    },
                    new object[]
                    {
                        new Bin(34),
                        new List<Bin>
                        {
                            new Bin(31),
                            new Bin(35),
                        }
                    },
                    new object[]
                    {
                        new Bin(36),
                        new List<Bin>
                        {
                            new Bin(33),
                            new Bin(35),
                        }
                    },
                    new object[]
                    {
                        new Bin(14),
                        new List<Bin>
                        {
                            new Bin(11),
                            new Bin(17),
                            new Bin(13),
                            new Bin(15),
                        }
                    }
                };
            }
        }
    }
}
