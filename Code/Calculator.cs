using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5
{
    abstract class Calculator
    {

        public abstract int Task(int num1, int num2);

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
