using Xunit;

namespace AdvancedOperations.Test
{
    public class PowerTests
    {
        private Power power = new Power();

        [Fact]
        public void Operation_PerformsCorrectly()
        {
            var result = power.Perform(new double[] {2,3});

            Assert.Equal(8, result);
        }  
    }
}