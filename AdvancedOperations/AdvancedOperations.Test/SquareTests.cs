using Xunit;

namespace AdvancedOperations.Test
{
    public class SquareTests
    {
        private Square square = new Square();

        [Fact]
        public void Operation_PerformsCorrectly()
        {
            var result = square.Perform(new double[] { 4 });

            Assert.Equal(16, result);
        } 
    }
}