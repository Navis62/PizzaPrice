namespace PizzaPrice
{
    public class PizzaPriceService
    {
        public double GetIngredientPrice(Ingredient ingredient)
        {
            try
            {
                var price = Ingredients.IngredientList.Single(x => x.Name == ingredient.Name).Price;
                if (price == 0)
                {
                    throw new ArgumentException("Le prix de cet ingrédient n'est pas défini");
                }
                return price;
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
                var pizza = Pizzas.PizzaList.Single(x => x.Name == name);
                return pizza.Ingredients.Sum(GetIngredientPrice);
            }
            catch (ArgumentException exc)
            {
                throw new ApplicationException("Cette pizza contient un ingrédient qui n'a pas de prix");
            }
            catch
            {
                throw new ArgumentException("Cette pizza n'existe pas");
            }
        }
    }
}
