using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入整型操作数及操作符（例： 1 + 2 ）：");
            string str = Console.ReadLine();
            string[] data = str.Split(' ');

            Calculator count = new Calculator();

            switch (data[1])
            {
                case "+": Console.WriteLine("和是：{0}  字符串拼接结果为：{1}", count.Add(int.Parse(data[0]), int.Parse(data[2])), count.Add(data[0], data[2])); break;
                case "-": Console.WriteLine("差是：{0}  字符串相除结果为：{1}", count.Sub(int.Parse(data[0]), int.Parse(data[2])), count.Sub(data[0], data[2])); break;
                case "*": Console.WriteLine("积是：{0}", count.Multiply(int.Parse(data[0]), int.Parse(data[2]))); break;
                case "/": Console.Write("商是："); count.Divide(int.Parse(data[0]), int.Parse(data[2])); break;

            }
        }
    }
}
