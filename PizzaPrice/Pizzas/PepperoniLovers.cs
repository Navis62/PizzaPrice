namespace PizzaPrice.Pizzas
{
    public class PepperoniLovers : PizzaClass
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
