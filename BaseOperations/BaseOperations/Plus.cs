using System.Linq;
using Domain;

namespace BaseOperations
{
    public class Plus:IOperation
    {
        public double Perform(params double[] arguments)
        {
            return arguments.Sum();
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
            get { return "+"; }
        }
    }
}