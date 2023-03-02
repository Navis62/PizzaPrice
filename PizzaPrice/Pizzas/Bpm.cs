namespace PizzaPrice.Pizzas
{
    public class Bpm : Pizza
    {
        public Bpm() :
            base("BPM", new[]
            {
                Ingredients.SauceBarbecue,
                Ingredients.Mozzarella,
                Ingredients.EmmietteDeBoeuf,
                Ingredients.PouletRoti,
                Ingredients.Merguez
            })
        { }
    }
}
