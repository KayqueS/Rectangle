using System;

namespace rectangle
{
    class Rectangle
    {
        public double Width;
        public double Height;
        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2.0) + Math.Pow(Height, 2.0));
        }
    }
}
