using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc
{
    public class Calculator
    {
        public int Sum(params int[] values)
        {
            return values.Sum();
        }
    }
}
