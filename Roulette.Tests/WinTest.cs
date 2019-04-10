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

            Assert.Equal(expected, actual);
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
                            new Bin(2),
                            new Bin(4),
                        }            
                    },
                };
            }
        }
    }
}
