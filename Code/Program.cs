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
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("请输入整型操作数及操作符（例： 1 + 2 ）：");
                string str = Console.ReadLine();
                string[] data = str.Split(' ');

                Calculator count;

                switch (data[1])
                {
                    case "+": Add add = new Add(); count = add; Console.WriteLine("和是：{0}", count.Task(int.Parse(data[0]), int.Parse(data[2]))); break;
                    case "-": Subtract sub = new Subtract(); count = sub; Console.WriteLine("差是：{0}", count.Task(int.Parse(data[0]), int.Parse(data[2]))); break;
                    case "*": Multiply mtp = new Multiply(); count = mtp; Console.WriteLine("积是：{0}", count.Task(int.Parse(data[0]), int.Parse(data[2]))); break;
                    case "/": Divide dvd = new Divide(); count = dvd; Console.Write("商是："); count.Task(int.Parse(data[0]), int.Parse(data[2])); break;
                    case "&": And and = new And(); count = and; Console.WriteLine("按位与结果是：{0}", count.Task(int.Parse(data[0]), int.Parse(data[2]))); break;
                    case "%": Remainder rmd = new Remainder(); count = rmd; Console.WriteLine("余数是：{0}", count.Task(int.Parse(data[0]), int.Parse(data[2]))); break;
                }
            }

        }
    }
}
