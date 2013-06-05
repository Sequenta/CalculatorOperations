using Domain;

namespace AdvancedOperations
{
    public class Power:IOperation
    {
        public double Perform(params double[] arguments)
        {
            var power = arguments[1];
            var result = arguments[0];
            for (var i = 1; i < power; i++)
            {
                result *= arguments[0];
            }
            return result;
        }

        public int Arity
        {
            get { return 2; }
        }

        public int Priority
        {
            get { return 2; }
        }

        public string StringPresentation
        {
            get { return "^"; }
        }
    }
}