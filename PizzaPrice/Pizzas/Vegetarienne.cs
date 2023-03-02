using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPrice.Pizzas
{
    public class Vegetarienne : Pizza
    {
        public Vegetarienne() :
            base("Végétarienne", new[]
            {
                Ingredients.SauceTomate, 
                Ingredients.Mozzarella,
                Ingredients.Champignon, 
                Ingredients.OignonRouge, 
                Ingredients.PoivronVert,
                Ingredients.Tomate,
                Ingredients.OliveNoire
            })
        { }
    }
}
