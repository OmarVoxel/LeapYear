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
        
        [Theory]
        [InlineData(40)]
        [InlineData(80)]
        [InlineData(4)]
        public void ReturnsTrueIfYearIsDivisibleBy4ButNotBy100(int year)
        {
            Assert.True(LeapYear.Calculate(year));
        }
        
        [Theory]
        [InlineData(5)]
        [InlineData(9)]
        [InlineData(10)]
        public void ReturnsFalseIfYearIsntDivisibleBy4(int year)
        {
            Assert.False(LeapYear.Calculate(year));
        }

        
    }
}