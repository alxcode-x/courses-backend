using System;
using System.Collections.Generic;

namespace Figures_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();

            figures.Add(new Figure(4, 4));
            figures.Add(new Figure(2, 10));

            foreach (var item in figures)
            {
                Console.WriteLine(item.Area((result) => item.data1 * item.data2));
            }
        }
    }
}
