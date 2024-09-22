﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab1.Классы
{
    internal class SimpsonsCalculate : ICalculateIntegral
    {
        public double Calculate(double lower, double upper, int count, Func<double, double> func)
        {
            double step = (upper - lower) / count;
            double sum = func(lower) + func(upper);
            double x = lower + step;
            for (int i = 1; i < count; i++)
            {
                sum += (i % 2 == 0 ? 2 : 4) * func(x);
                x += step;
            }
            return sum * step / 3;
        }
    }
}
