using Xunit;

namespace BaseOperations.Test
{
    public class PlusTests
    {
        [Fact]
        public void Operation_PerformsCorrectly()
        {
            var plus = new Plus();

            var result = plus.Perform(new double[] {2, 2});

            Assert.Equal(4,result);
        }
    }
}