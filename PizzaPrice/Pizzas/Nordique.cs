namespace PizzaPrice.Pizzas
{
    public class Nordique : PizzaClass
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
