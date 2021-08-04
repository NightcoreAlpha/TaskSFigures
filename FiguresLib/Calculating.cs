using System;

namespace FiguresLib
{
    public class Calculating
    {
        double a, b, c;
        public double calculating(double r)
        {
            return Math.PI * (r * r);
        }
        public double calculating(double x1, double x2, double x3)
        {
            double p = (x1 + x2 + x3) / 2;
            return Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));
        }

        public string rectangular(double x1, double x2, double x3)
        {
            if ((x3 * x3) == (x1 * x1) + (x2 * x2) || (x2 * x2) == (x1 * x1) + (x3 * x3) || (x1 * x1) == (x2 * x2) + (x3 * x3))
            {
                return "Треугольник является прямоугольным";
            }
            else return "Треугольник не является прямоугольным";
        }
    }
}