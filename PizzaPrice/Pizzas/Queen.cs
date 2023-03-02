namespace PizzaPrice.Pizzas
{
    public class Queen : PizzaClass
    {
        public Queen() :
            base("Queen", new[]
            {
                Ingredients.SauceTomate,
                Ingredients.Mozzarella,
                Ingredients.Jambon,
                Ingredients.Champignon
            })
        { }
    }
}
