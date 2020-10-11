using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5
{
    class Divide:Calculator
    {
        public override int Task(int _firstNumber, int _secondNumber)
        {
            divide(_firstNumber, _secondNumber);
            return 0;
        }
        public void divide(int _firstNumber, int _secondNumber)
        {
            try
            {
                Console.WriteLine(_firstNumber / _secondNumber);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("错误：除数为0！");
            }
            catch (FormatException)
            {
                Console.WriteLine("输入格式错误：应输入一个整数！");
            }
        }
    }
}
