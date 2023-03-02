namespace PizzaPrice.Pizzas
{
    public class Campagnarde : PizzaClass
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
