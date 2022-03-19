using System;
namespace Fundamentals.Models
{
    public interface IAlcoholicDrink
    {
        public int Alcohol { get; set; }

        public void MaxRecommended(int quantity);

    }
}
