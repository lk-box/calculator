using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5
{
    class Remainder:Calculator
    {
        public override int Task(int _firstNumber, int _secondNumber)
        {
            return _firstNumber % _secondNumber;
        }
    }
}
