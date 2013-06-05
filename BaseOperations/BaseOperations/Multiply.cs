using System;
using Domain;

namespace BaseOperations
{
    public class Multiply:IOperation
    {
        public double Perform(params double[] arguments)
        {
            var result = arguments[1] * arguments[0];
            if(!double.IsInfinity(result))
            {
                return result;
            }
            throw new OverflowException("Слишком большие числа");
        }

        public int Arity
        {
            get { return 2; }
        }

        public int Priority
        {
            get { return 3; }
        }

        public string StringPresentation
        {
            get { return "*"; }
        }
    }
}