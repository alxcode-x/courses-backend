using System;
using Fundamentals.Models;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var beer = new Beer(10);
            ShowRecomentations(beer);
        }

        static void ShowRecomentations(IAlcoholicDrink drink)
        {
            drink.MaxRecommended(15);
        }
    }
}
