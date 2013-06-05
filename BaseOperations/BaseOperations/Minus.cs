using Domain;

namespace BaseOperations
{
    public class Minus:IOperation
    {
        public double Perform(params double[] arguments)
        {
            return arguments[0] - arguments[1];
        }

        public int Arity
        {
            get { return 2; }
        }
        public int Priority
        {
            get { return 4; }
        }
        public string StringPresentation
        {
            get { return "-"; }
        }
    }
}