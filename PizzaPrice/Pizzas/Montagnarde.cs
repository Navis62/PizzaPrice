namespace PizzaPrice.Pizzas
{
    public class Montagnarde : PizzaClass
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
