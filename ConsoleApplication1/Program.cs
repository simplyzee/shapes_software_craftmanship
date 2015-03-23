using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Calculator
    {
        private int _width;
        private int _length;
        private int _size;
        private int _area;

        public int CalculateRectanglePerimeter(int width, int length)
        {
            _width  = width;
            _length = length;
            _area   = length * width;

            return (2 * _length) + (2 * _width);
        }

        public int CalculateSquarePerimeter(int size)
        {
            _size = size;
            _area = size * size;

            return 4 * _size;
        }

        public Double CalculateCirclePerimeter(Double radius)
        {
            return 2 * Math.PI * radius;
        }

        public int CalculateArea()
        {
            return _area;
        }    
    }

    /*public class Shape : Calculator
    {
        public int Rectangle()
        {
            for (int i = 0; i <= this._kLength; i++)
            {
                for (int j = 0; j <= this._kWidth; j++)
                {
                    Console.Write("*");
                }
            }

            return this.CalculateRectanglePerimeter(this.KWidth, this.KLength);
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // Calculate Rectangle Perimeter
            int rectWidth = 10;
            int rectLength = 50;
            Console.WriteLine(calculator.CalculateRectanglePerimeter(rectWidth, rectLength));
            Console.WriteLine("Rectangle Area: " + calculator.CalculateArea());

            // Calculate Square Perimeter
            int sizeOfSquare = 50;
            Console.WriteLine(calculator.CalculateSquarePerimeter(sizeOfSquare));
            Console.WriteLine("Square Area: " + calculator.CalculateArea());

            Double radius = 20;
            Console.WriteLine(calculator.CalculateCirclePerimeter(radius));

            Console.ReadLine();
        }
    }
}
