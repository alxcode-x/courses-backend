using System;
namespace Figures
{
    public class Circle : Figure, IFigure
    {
        public Circle(float data1, float data2 = 0) : base(data1, data2)
        {
            this.data1 = data1;
            this.data2 = data2;

        }

        public float Area()
        {
            return (float)3.141592 * (float)Math.Pow(data1,2);
        }
    }
}
