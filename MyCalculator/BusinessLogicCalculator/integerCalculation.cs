using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicCalculator
{
    public class integerCalculation : Calculator
    {
        public int addNumber(int num1, int num2)
        {
            return num1 + num2;
        }

        public Double addNumber(Double num1, Double num2)
        {
            throw new NotImplementedException();
        }

        public int divideNumber(int num1, int num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException();
            else
                return num1 / num2;
        }

        public Double divideNumber(Double num1, Double num2)
        {
            throw new NotImplementedException();
        }

        public int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public Double multiply(Double num1, Double num2)
        {
            throw new NotImplementedException();
        }

        public int substract(int num1, int num2)
        {
            return num1 - num2;
        }

        public Double substract(Double num1, Double num2)
        {
            throw new NotImplementedException();
        }
    }
}
