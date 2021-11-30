using System;
using Xunit;

namespace LeapYear.Tests
{
    public class YearShould
    {
        [Theory]
        [InlineData(2000)]
        [InlineData(4000)]
        [InlineData(6000)]
        public void ReturnsTrueIfYearIsDivisibleBy400(int year)
        {
            Assert.True(LeapYear.Calculate(year));
        }
        
        [Fact]
        public void ReturnsFalseIfYearIsDivisibleBy100ButNotBy400()
        {
            Assert.False(LeapYear.Calculate(1000));
        }
    }
}