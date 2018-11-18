using Compiler;
using Xunit;

namespace tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Calculate_EmptyExpression_EmptyResult()
        {
            var calculator = new Calculator();
            Assert.Equal("", calculator.Calculate(""));
        }

        [Fact]
        public void Calculate_NullExpression_EmptyResult()
        {
            var calculator = new Calculator();
            Assert.Equal("", calculator.Calculate(null));
        }

        [Fact]
        public void Calculate_OnePlusTwoExpression_ThreeResult()
        {
            var calculator = new Calculator();
            Assert.Equal("3", calculator.Calculate("1+2"));
        }

        [Fact]
        public void Calculate_TwoPlusTwoExpression_FourResult()
        {
            var calculator = new Calculator();
            Assert.Equal("4", calculator.Calculate("2+2"));
        }
    }
}
