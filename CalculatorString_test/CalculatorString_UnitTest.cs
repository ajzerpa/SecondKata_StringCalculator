using System;
using Xunit;
using SecondKata_StringCalculator_Interactions;

namespace CalculatorString_test
{
    public class CalculatorString_UnitTest
    {
        [Fact]
        public void stringCalculator_emptyTest()
        {
            CalculatorString calculator = new CalculatorString();
            var result = calculator.Add(string.Empty);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1", 1),
            InlineData("2,3", 5),
            InlineData("1,2", 3),
            InlineData("1,2,3", 6),
            InlineData("1,2,3,4", 10),
            InlineData("1\n2,3", 6),
            InlineData("2,2\n3\n3", 10),
            InlineData("//;\n1;2", 3),
            InlineData("//[%][#]\n1%2#7", 10),
            InlineData("//[%][#][(]\n1%2#7(11%4", 25),
            InlineData("2,2,1\n1005", 5)]
        public void stringCalculator_addOneOrTwo(string numbers, int expectedResult)
        {
            CalculatorString calculator = new CalculatorString();
            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void stringCalculator_negativesTest()
        {
            string numbers = "2,2,1\n-1";
            CalculatorString calculator = new CalculatorString();
            Assert.Throws<Exception>(() => calculator.Add(numbers));
        }
    }
}
