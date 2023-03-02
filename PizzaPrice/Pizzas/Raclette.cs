namespace PizzaPrice.Pizzas
{
    public class Raclette : PizzaClass
    {
        public Raclette() :
            base("Raclette", new[]
            {
                Ingredients.CremeFraiche,
                Ingredients.Mozzarella,
                Ingredients.PommeDeTerre,
                Ingredients.Lardon,
                Ingredients.FromageRaclette
            })
        { }
    }
}
