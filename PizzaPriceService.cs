namespace PizzaPrice
{
    public class PizzaPriceService
    {
        public double GetIngredientPrice(string ingredient)
        {
            try
            {
                return Reference.Ingredients.Single(x => x.Name == ingredient).Price;
            }
            catch
            {
                return 0;
            }
        }

        public double GetPizzaPrice(string name)
        {
            try
            {
                var pizza = Reference.Pizzas.Single(x => x.Name == name);
                return pizza.Ingredients.Sum(GetIngredientPrice);
            }
            catch
            {
                throw new ArgumentException("Cette pizza n'existe pas");
            }
        }
    }
}
