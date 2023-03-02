namespace PizzaPrice.Pizzas
{
    public class ChickenParmesan : Pizza
    {
        public ChickenParmesan() :
            base("Chicken Parmesan", new[]
            {
                Ingredients.CremeFraiche,
                Ingredients.Mozzarella,
                Ingredients.PouletRoti,
                Ingredients.Tomate,
                Ingredients.Parmigiano
            })
        { }
    }
}
