using System;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle x = new Rectangle();

            Console.WriteLine("Enter the width and height of the rectangle: ");
            x.Width = double.Parse(Console.ReadLine());
            x.Height = double.Parse(Console.ReadLine());
            Console.WriteLine($"AREA = {x.Area():F2}");
            Console.WriteLine($"PERIMETER = {x.Perimeter():F2}");
            Console.WriteLine($"DIAGONAL = {x.Diagonal():F2}");
        }
    }
}
