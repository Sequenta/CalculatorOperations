using Xunit;

namespace AdvancedOperations.Test
{
    public class FactorialTests
    {
        private Factorial factorial = new Factorial();

        [Fact]
        public void Operation_PerformsCorrectly()
        {
            var result = factorial.Perform(new double[] {4});

            Assert.Equal(24, result);
        }
    }
}