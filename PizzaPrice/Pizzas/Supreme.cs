namespace PizzaPrice.Pizzas
{
    public class Supreme : Pizza
    {
        public Supreme() :
            base("Suprême", new[]
            {
                Ingredients.SauceTomate,
                Ingredients.Mozzarella,
                Ingredients.EmmietteDeBoeuf,
                Ingredients.SaucissePepperoni,
                Ingredients.Champignon,
                Ingredients.OignonRouge,
                Ingredients.PoivronVert
            })
        { }
    }
}
