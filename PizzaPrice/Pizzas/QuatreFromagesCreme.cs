﻿namespace PizzaPrice.Pizzas
{
    public class QuatreFromagesCreme : PizzaClass
    {
        public QuatreFromagesCreme() :
            base("4 Fromages base crème", new[]
            {
                Ingredients.CremeFraiche,
                Ingredients.Mozzarella,
                Ingredients.FromageDeChevre,
                Ingredients.Emmental,
                Ingredients.FourmeDAmbert
            })
        { }
    }
}
