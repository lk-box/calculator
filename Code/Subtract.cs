using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5
{
    class Subtract:Calculator
    {
        public override int Task(int _firstNumber, int _secondNumber)
        {
            return _firstNumber - _secondNumber;
        }
        public string dvd(string _firstNumber, string _secondNumber)
        {
            int num1 = int.Parse(_firstNumber);
            int num2 = int.Parse(_secondNumber);
            return (num1 / num2).ToString();
        }
    }
}
