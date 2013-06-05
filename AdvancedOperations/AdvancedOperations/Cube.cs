using Domain;

namespace AdvancedOperations
{
    public class Cube:IOperation
    {
        public double Perform(params double[] arguments)
        {
            return arguments[0]*arguments[0]*arguments[0];
        }

        public int Arity
        {
            get { return 1; }
        }

        public int Priority
        {
            get { return 2; }
        }

        public string StringPresentation
        {
            get { return "cube"; }
        }
    }
}