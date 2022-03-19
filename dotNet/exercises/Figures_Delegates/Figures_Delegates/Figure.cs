using System;
namespace Figures_Delegates
{
    public class Figure
    {
        public double data1 { get; set; }
        public double data2 { get; set; }
        private double result { get; set; }

        public Figure(double data1, double data2 = 0)
        {
            this.data1 = data1;
            this.data2 = data2;
        }

        public double Area(Func<double, double> area)
        {
            return area(result);
        }

    }
}
