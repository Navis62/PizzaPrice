namespace PizzaPrice.Pizzas
{
    public class QuatreFromagesTomate : PizzaClass
    {
        public QuatreFromagesTomate() :
            base("4 Fromages base tomate", new[]
            {
                Ingredients.SauceTomate,
                Ingredients.Mozzarella,
                Ingredients.FromageDeChevre,
                Ingredients.Emmental,
                Ingredients.FourmeDAmbert
            })
        { }
    }
}
