using System;
using Xunit;

namespace BaseOperations.Test
{
    public class MultiplyTests
    {
        Multiply multiply = new Multiply();

        [Fact]
        public void Operation_PerformsCorrectly()
        {
            var result = multiply.Perform(new double[] {6, 6});

            Assert.Equal(36,result);
        }

        [Fact]
        public void Throws_OverflowException()
        {
            Assert.Throws<OverflowException>(() => multiply.Perform(new[] { double.MaxValue, double.MaxValue }));
        }
    }
}