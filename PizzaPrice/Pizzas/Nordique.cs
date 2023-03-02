namespace PizzaPrice.Pizzas
{
    public class Nordique : Pizza
    {
        public Nordique() :
            base("Nordique", new[]
            {
                Ingredients.CremeFraiche,
                Ingredients.Mozzarella,
                Ingredients.Saumon
            })
        { }
    }
}
