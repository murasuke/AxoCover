﻿namespace TestTargetExeForm
{
    public class CalcLogic
    {
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Sub(decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal Mul(decimal a, decimal b)
        {
            return a * b;
        }

        public static decimal Div(decimal a, decimal b)
        {
            if (b == 0)
            {
                return 0;
            }

            return a / b;
        }
    }
}
