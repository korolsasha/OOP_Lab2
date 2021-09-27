using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task4
{
    public class Point
    {
        private int x;
        public int X { get { return x; } }

        private int y;
        public int Y { get { return y; } }

        private string str;
        public string Str { get { return str; } }

        public Point(int x, int y, string str)
        {
            this.x = x;
            this.y = y;
            this.str = str;
        }
    }

    public class Figure
    {
        private Point[] points;

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
        }

        private static double LengthSide(Point A, Point B)
        {
            return Math.Sqrt( Math.Pow(B.X - A.X, 2d) + Math.Pow(B.Y - A.Y, 2d) );
        }


        private double PerimeterCalculator()
        {
            double result = 0d;

            for (int i = 0; i < points.Length - 1; i++)
                result += LengthSide(points[i], points[i + 1]);

            result += LengthSide(points[0], points[points.Length - 1]);

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть кількість вершин (від 3 до 5): ");
            int pointsCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            if (pointsCount < 3 || pointsCount > 5)
            {
                Console.WriteLine("Введена фігура не підтримується");
                Console.ReadLine();
                return;
            }

            var points = new Point[pointsCount];

            for (int i = 0; i < pointsCount; i++)
            {
                Console.WriteLine($"{i + 1}-а точка:");

                Console.Write("X: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Y: ");
                int y = Convert.ToInt32(Console.ReadLine());

                points[i] = new Point(x, y, "");

                Console.WriteLine();
            }

            Figure figure = null;
            string figureType = null;

            if (pointsCount == 3)
            {
                figure = new Figure(points[0], points[1], points[2]);
                figureType = "Трикутник";
            }

            if (pointsCount == 4)
            {
                figure = new Figure( points[0], points[1], points[2], points[3] );
                figureType = "Чотирикутник";
            }

            if (pointsCount == 5)
            {
                figure = new Figure( points[0], points[1], points[2], points[3], points[4] );
                figureType = "П'ятикутник";
            }

            if (pointsCount < 3 || pointsCount > 5) { Console.WriteLine("Введена фігура не підтримується"); Console.ReadLine(); }

            Console.WriteLine($"Тип фігури: {figureType}");
            Console.WriteLine($"Периметр фігури: {figure.Perimeter}");
            Console.ReadLine();
        }
    }
}
