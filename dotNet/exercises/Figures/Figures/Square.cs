using System;
namespace Figures
{
    public class Square : Figure, IFigure
    { 
        public Square(float data1, float data2) : base (data1, data2)
        {
            this.data1 = data1;
            this.data2 = data2;

        }

        public float Area()
        {
            return data1 * data2;
        }
    }
}
