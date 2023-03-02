namespace PizzaPrice.Pizzas
{
    public class PepperoniLovers : Pizza
    {
        public PepperoniLovers() :
            base("Pepperoni Lovers", new[]
            {
                Ingredients.SauceTomate,
                Ingredients.Mozzarella,
                Ingredients.SaucissePepperoni
            })
        { }
    }
}
