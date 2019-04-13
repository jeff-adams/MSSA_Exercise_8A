using System;
using System.Collections.Generic;
using Xunit;
using Roulette.Models;

namespace Roulette.Tests
{
    public class WinTest
    {
        #region Split Test

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

        #endregion

        #region Double Street Test

        [Theory]
        [MemberData(nameof(DoubleStreetTestData))]
        public void DoubleStreetTest(Bin winningBin, List<Bin> expected)
        {
            var roulette = new Models.Roulette();
            var win = new Win(roulette);
            var actual = win.DoubleStreet(winningBin);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.Equal(actual[i].Number, expected[i].Number);   
            }
        }

        public static IEnumerable<object[]> DoubleStreetTestData
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
                            new Bin(1),
                            new Bin(2),
                            new Bin(3),
                            new Bin(4),
                            new Bin(5),
                            new Bin(6),
                        }            
                    },
                    new object[]
                    {
                        new Bin(36),
                        new List<Bin>
                        {
                            new Bin(31),
                            new Bin(32),
                            new Bin(33),
                            new Bin(34),
                            new Bin(35),
                            new Bin(36),
                        }
                    },
                    new object[]
                    {
                        new Bin(11),
                        new List<Bin>
                        {
                            new Bin(7),
                            new Bin(8),
                            new Bin(9),
                            new Bin(10),
                            new Bin(11),
                            new Bin(12),
                            new Bin(13),
                            new Bin(14),
                            new Bin(15),
                        }
                    },
                };
            }
        }

        #endregion

        #region Corner Test

        [Theory]
        [MemberData(nameof(CornerTestData))]
        public void CornerTest(Bin winningBin, List<Bin> expected)
        {
            var roulette = new Models.Roulette();
            var win = new Win(roulette);
            var actual = win.Corner(winningBin);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.Equal(actual[i].Number, expected[i].Number);   
            }
        }

        public static IEnumerable<object[]> CornerTestData
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
                            new Bin(1),
                            new Bin(2),
                            new Bin(4),
                            new Bin(5),
                        }            
                    },
                    new object[]
                    {
                        new Bin(36),
                        new List<Bin>
                        {
                            new Bin(32),
                            new Bin(33),
                            new Bin(35),
                            new Bin(36),
                        }
                    },
                    new object[]
                    {
                        new Bin(11),
                        new List<Bin>
                        {
                            new Bin(8),
                            new Bin(9),
                            new Bin(11),
                            new Bin(12),
                            new Bin(11),
                            new Bin(12),
                            new Bin(14),
                            new Bin(15),
                            new Bin(10),
                            new Bin(11),
                            new Bin(13),
                            new Bin(14),
                            new Bin(7),
                            new Bin(8),
                            new Bin(10),
                            new Bin(11),
                        }
                    },
                };
            }
        }

        #endregion
    }
}
