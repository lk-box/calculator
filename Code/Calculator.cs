using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5
{
    class Calculator
    {  
        public int Add(int _firstNumber, int _secondNumber)
        {
            return _firstNumber + _secondNumber; 
        }

        public string Add(string _firstNumber, string _secondNumber)
        {
            return _firstNumber + _secondNumber;
        }

        public int Sub(int _firstNumber, int _secondNumber)
        {
            return _firstNumber - _secondNumber;
        }

        public string Sub(string _firstNumber, string _secondNumber)
        {
            int num1 = int.Parse(_firstNumber);
            int num2 = int.Parse(_secondNumber);
            return (num1/num2).ToString();
        }

        public int Multiply(int _firstNumber, int _secondNumber)
        {
            return _firstNumber * _secondNumber;
        }

        public void Divide(int _firstNumber,int _secondNumber)
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

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Calculator comObj = obj as Calculator;
            if (comObj == null)
            {
                return false;
            }
            else
            {
                return base.Equals(comObj);
            }
        }
    }
}
