namespace PizzaPrice.Pizzas
{
    public class Campagnarde : Pizza
    {
        public Campagnarde() :
            base("Campagnarde", new[]
            {
                Ingredients.CremeFraiche,
                Ingredients.Mozzarella,
                Ingredients.Lardon,
                Ingredients.OignonRouge,
                Ingredients.Champignon
            })
        { }
    }
}
