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

        [Fact]
        public void Calculate_TenPlusTwoExpression_TwelveResult()
        {
            var calculator = new Calculator();
            Assert.Equal("12", calculator.Calculate("10+2"));
        }

        [Fact]
        public void Calculate_TenPlusTenExpression_TwentyResult()
        {
            var calculator = new Calculator();
            Assert.Equal("20", calculator.Calculate("10+10"));
        }

        [Fact]
        public void Calculate_TenPlusTenExpressionWithSpace_TwentyResult()
        {
            var calculator = new Calculator();
            Assert.Equal("20", calculator.Calculate("10 +10"));
        }

        [Fact]
        public void Calculate_TenMinusFiveExpressionWithSpace_FiveResult()
        {
            var calculator = new Calculator();
            Assert.Equal("5", calculator.Calculate("10 - 5"));
        }

        [Fact]
        public void Calculate_TwoMultipliedByTwoExpression_FourResult()
        {
            var calculator = new Calculator();
            Assert.Equal("4", calculator.Calculate("2*2"));
        }

        [Fact]
        public void Calculate_FourDividedByTwoExpression_TwoResult()
        {
            var calculator = new Calculator();
            Assert.Equal("2", calculator.Calculate("4/2"));
        }

        [Fact]
        public void Calculate_FourPlusTwoMinusThreeExpression_ThreeResult()
        {
            var calculator = new Calculator();
            Assert.Equal("3", calculator.Calculate("4+2-3"));
        }

        [Fact]
        public void Calculate_FourMyltiplyByTwoMinusThreeExpression_FiveResult()
        {
            var calculator = new Calculator();
            Assert.Equal("5", calculator.Calculate("4*2-3"));
        }

        [Fact]
        public void Calculate_SixDivideByTwoMinusThreeExpression_ZeroResult()
        {
            var calculator = new Calculator();
            Assert.Equal("0", calculator.Calculate("6/2-3"));
        }
    }
}
