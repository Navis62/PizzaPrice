namespace PizzaPrice.Pizzas
{
    public class Samourai : Pizza
    {
        public Samourai() :
            base("Samouraï", new[]
            {
                Ingredients.SauceTomate,
                Ingredients.Mozzarella,
                Ingredients.Merguez,
                Ingredients.PouletRoti,
                Ingredients.OignonRouge,
                Ingredients.SauceSamourai
            })
        { }
    }
}
