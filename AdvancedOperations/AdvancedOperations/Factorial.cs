using System;
using Domain;

namespace AdvancedOperations
{
    public class Factorial:IOperation
    {
        public double Perform(params double[] arguments)
        {
            var result = GetFactorial(arguments[0]);
            if (!double.IsInfinity(result))
            {
                return result;
            }
            throw new OverflowException("Результат факториала слишком большой");
        }

        private double GetFactorial(double number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
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
            get { return "fact"; }
        }
    }
}