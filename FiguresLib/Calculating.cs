using System;

namespace FiguresLib
{
    public class Calculating
    {
        public double calculating(double r)
        {
            double d = r + r, s;
            s = Math.PI * (r*r);
            return s;
        }
        public double calculating(double x1,double x2, double x3)
        {
            double p = 0, s = 0;
            p = (x1 + x2 + x3) / 2;
            s = Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));
            return s;
        }


   
    }
}
/*
Формула площади круга: Площадь круга ,
где r - радиус круга, d - диаметр
*/