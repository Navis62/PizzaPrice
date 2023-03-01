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
                throw new ArgumentException("Cette ingrédient n'existe pas");
            }
        }

        public double GetPizzaPrice(string name)
        {
            try
            {
                var pizza = Reference.Pizzas.Single(x => x.Name == name);
                return pizza.Ingredients.Sum(GetIngredientPrice);
            }
            catch (ArgumentException exc)
            {
                throw new ApplicationException("Cette pizza contient un ingrédient qui n'existe pas");
            }
            catch
            {
                throw new ArgumentException("Cette pizza n'existe pas");
            }
        }
    }
}
