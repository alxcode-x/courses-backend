using System;
namespace Fundamentals.Models
{
    public class Beer : Bebida, IAlcoholicDrink
    {
        public Beer(int quantity, string name="Beer") : base(name, quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }

        public int Alcohol { get; set; }


        public void MaxRecommended(int quantity)
        {
            Console.WriteLine(this.name+" - Max Recommended: " + quantity);
        }
    }
}
