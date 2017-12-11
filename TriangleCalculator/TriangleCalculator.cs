using System;

namespace TriangleCalculator
{
    public class TriangleCalculator
    {
        public static double CalculateArea(double xSide, double ySide, double zSide)
        {
            if (xSide + ySide <= zSide || xSide + zSide <= ySide || ySide + zSide <= xSide)
            {
                throw new WrongTriangleException("Такого треугольника не существует!");
            }
            double p = (xSide + ySide + zSide) / 2;
            double s = Math.Sqrt(p * (p - xSide) * (p - ySide) * (p - zSide));
            return s;
        }
    }
    public class WrongTriangleException:Exception
        {
        public WrongTriangleException(string message) : base(message)
        {
        }
    }
}
