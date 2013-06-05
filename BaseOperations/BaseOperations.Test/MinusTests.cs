using Xunit;

namespace BaseOperations.Test
{
    public class MinusTests
    {
        [Fact]
        public void Operation_PerformsCorrectly()
        {
            var minus = new Minus();

            var result = minus.Perform(new double[] {2, 2});

            Assert.Equal(0,result);
        } 
    }
}