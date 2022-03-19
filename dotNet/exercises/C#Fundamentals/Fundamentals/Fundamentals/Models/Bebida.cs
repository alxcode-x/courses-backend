using System;
namespace Fundamentals.Models
{
    public class Bebida
    {
        public string name  { get; set; }
        public int quantity { get; set; }

        public Bebida(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }

        public void Drink(int quantity)
        {
            this.quantity = quantity;
            Console.WriteLine("Drink: " + quantity);
        }
    }
}
