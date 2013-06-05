using System;
using Domain;

namespace BaseOperations
{
    public class Divide:IOperation
    {
        public double Perform(params double[] arguments)
        {
            var result = arguments[0]/arguments[1];

            if (!double.IsInfinity(result))
            {
                return result;
            }
            throw new DivideByZeroException("Попытка деления на ноль");
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
            get { return "/"; }
        }
    }
}