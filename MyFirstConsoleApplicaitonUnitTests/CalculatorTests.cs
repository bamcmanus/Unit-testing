using FluentAssertions;
using System;
using Xunit;

namespace Calculator
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculator_Add_Success()
        {
            var calc = new Calculator();
            var first = 12;
            var second = 12;
            var result = calc.add(first, second);
            result.Should().Be(24, "Because addition...");
        }

        [Fact]
        public void Calculator_Add_FirstZeroThrows()
        {
            var calc = new Calculator();

            Action action = () => calc.add(0, 12);

            action.Should().Throw<ArgumentOutOfRangeException>().Where(e => e.ParamName == "first");
        }

        [Fact]
        public void Calculator_Add_SecondZeroThrows()
        {
            var calc = new Calculator();

            Action action = () => calc.add(12, 0);

            action.Should().Throw<ArgumentOutOfRangeException>().Where(e => e.ParamName == "second");
        }
    }
}
