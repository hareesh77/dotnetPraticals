using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicCalculator
{
    interface Calculator
    {
        int addNumber(int num1, int num2);
        Double addNumber(Double num1, Double num2);

        int substract(int num1, int num2);
        Double substract(Double num1, Double num2);

        int multiply(int num1, int num2);
        Double multiply(Double num1, Double num2);

        int divideNumber(int num1, int num2);
        Double divideNumber(Double num1, Double num2);
    }
}
