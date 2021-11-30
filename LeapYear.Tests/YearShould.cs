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
        
        [Theory]
        [InlineData(1000)]
        [InlineData(500)]
        [InlineData(100)]
        public void ReturnsFalseIfYearIsDivisibleBy100ButNotBy400(int year)
        {
            Assert.False(LeapYear.Calculate(year));
        }
        
        [Fact]
        public void ReturnsTrueIfYearIsDivisibleBy4ButNotBy100()
        {
            Assert.True(LeapYear.Calculate(40));
        }
        
    }
}