namespace PizzaPrice.Pizzas
{
    public class HawaienneJambon : Pizza
    {
        public HawaienneJambon() :
            base("Hawaïenne Jambon", new[]
            {
                Ingredients.SauceTomate,
                Ingredients.Mozzarella,
                Ingredients.Jambon,
                Ingredients.Ananas
            })
        { }
    }
}
