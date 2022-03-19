using System;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFigure> figures = new List<IFigure>();
        
            figures.Add(new Square(4, 4));
            figures.Add(new Triangle(2, 4));
            figures.Add(new Circle(4));

            foreach (var figure in figures)
            {
                GetArea(figure);
            }
        }

        static void GetArea(IFigure figure)
        {
            Console.WriteLine(figure.Area());
        }
    }
}
