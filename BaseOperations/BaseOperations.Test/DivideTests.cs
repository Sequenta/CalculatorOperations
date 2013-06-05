using System;
using Xunit;

namespace BaseOperations.Test
{
    public class DivideTests
    {
        Divide divide = new Divide();

        [Fact]
        public void Operation_PerformsCorrectly()
        {
            var result = divide.Perform(new double[] { 36, 36 });

            Assert.Equal(1, result);
        }

        [Fact]
        public void Throws_DivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => divide.Perform(new double[] {36, 0}));
        }
    }
}