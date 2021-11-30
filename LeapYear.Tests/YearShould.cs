using System;
using Xunit;

namespace LeapYear.Tests
{
    public class YearShould
    {
        [Fact]
        public void ReturnsTrueIfYearIsDivisibleBy400()
        {
            Assert.True(LeapYear.Calculate(2000));
        }
    }
}