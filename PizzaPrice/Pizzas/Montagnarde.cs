namespace PizzaPrice.Pizzas
{
    public class Montagnarde : Pizza
    {
        public Montagnarde() :
            base("Montagnarde", new[]
            {
                Ingredients.CremeFraiche,
                Ingredients.Mozzarella,
                Ingredients.Jambon,
                Ingredients.FromageRaclette,
                Ingredients.Champignon
            })
        { }
    }
}
