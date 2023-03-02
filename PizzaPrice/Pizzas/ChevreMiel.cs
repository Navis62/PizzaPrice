namespace PizzaPrice.Pizzas
{
    public class ChevreMiel : Pizza
    {
        public ChevreMiel() :
            base("Chèvre Miel", new[]
            {
                Ingredients.CremeFraiche,
                Ingredients.Mozzarella,
                Ingredients.FromageDeChevre,
                Ingredients.Miel
            })
        { }
    }
}
