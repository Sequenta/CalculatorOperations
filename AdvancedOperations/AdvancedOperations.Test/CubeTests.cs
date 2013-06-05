using Xunit;

namespace AdvancedOperations.Test
{
    public class CubeTests
    {
        private Cube cube = new Cube();

        [Fact]
        public void Operation_PerformsCorrectly()
        {
            var result = cube.Perform(new double[] { 4 });

            Assert.Equal(64, result);
        } 
    }
}