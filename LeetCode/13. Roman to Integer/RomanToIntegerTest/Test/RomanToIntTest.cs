

namespace RomanToIntegerTest.Test;

public class RomanToIntTest
{
    [Theory]
    [InlineData("I", 1)]
    [InlineData("II", 2)]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("V", 5)]
    [InlineData("VI", 6)]
    [InlineData("IX", 9)]
    [InlineData("X", 10)]
    [InlineData("XL", 40)]
    [InlineData("L", 50)]
    [InlineData("XC", 90)]
    [InlineData("C", 100)]
    [InlineData("CD", 400)]
    [InlineData("D", 500)]
    [InlineData("CM", 900)]
    [InlineData("M", 1000)]
    [InlineData("LVIII", 58)]        
    [InlineData("MCMXCIV", 1994)]    
    [InlineData("MMMCMXCIX", 3999)]  
    [InlineData("DCXXI", 621)]      
    [InlineData("CCXLVI", 246)]
    public void RomanToInt_Should_Return_CorrectInt_When_Given_aRomanNumber(string romanNumber, int expected)
    {
        var result = Program.RomanToInt(romanNumber);
        Assert.Equal(expected, result);
    }
}
