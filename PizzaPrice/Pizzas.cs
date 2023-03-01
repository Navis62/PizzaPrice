namespace PizzaPrice
{
    public static class Pizzas
    {
        public static List<Pizza> PizzaList { get; set; } = new()
        {
            new Pizza("4 Fromages base crème", new[]
            {
                Ingredients.CremeFraiche, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Emmental, Ingredients.FourmeDAmbert
            }),
            new Pizza("4 Fromages base tomate", new[]
            {
                Ingredients.SauceTomate, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Emmental, Ingredients.FourmeDAmbert
            }),
            new Pizza("BPM", new[]
            {
                Ingredients.SauceBarbecue, Ingredients.Mozzarella, Ingredients.EmmietteDeBoeuf, Ingredients.PouletRoti, Ingredients.Merguez
            }),
            new Pizza("Pepperoni Lovers", new[]
            {
                Ingredients.SauceTomate, Ingredients.Mozzarella, Ingredients.SaucissePepperoni
            }),
            new Pizza("Queen", new[]
            {
                Ingredients.SauceTomate, Ingredients.Mozzarella, Ingredients.Jambon, Ingredients.Champignon
            }),
            new Pizza("Montagnarde", new[]
            {
                Ingredients.CremeFraiche, Ingredients.Mozzarella, Ingredients.Jambon, Ingredients.FromageRaclette, Ingredients.Champignon
            }),
            new Pizza("Suprême", new[]
            {
                Ingredients.SauceTomate, Ingredients.Mozzarella, Ingredients.EmmietteDeBoeuf, Ingredients.SaucissePepperoni, Ingredients.Champignon, Ingredients.OignonRouge, Ingredients.PoivronVert
            }),
            new Pizza("Raclette", new []
            {
                Ingredients.CremeFraiche, Ingredients.Mozzarella, Ingredients.PommeDeTerre, Ingredients.Lardon, Ingredients.FromageRaclette
            }),
            new Pizza("Chèvre Miel", new[]
            {
                Ingredients.CremeFraiche, Ingredients.Mozzarella, Ingredients.FromageDeChevre, Ingredients.Miel
            }),
            new Pizza("Nordique", new[]
            {
                Ingredients.CremeFraiche, Ingredients.Mozzarella, Ingredients.Saumon
            }),
            new Pizza("Campagnarde", new[]
            {
                Ingredients.CremeFraiche, Ingredients.Mozzarella, Ingredients.Lardon, Ingredients.OignonRouge, Ingredients.Champignon
            }),
            new Pizza("Samouraï", new[]
            {
                Ingredients.SauceTomate, Ingredients.Mozzarella, Ingredients.Merguez, Ingredients.PouletRoti, Ingredients.OignonRouge, Ingredients.SauceSamourai
            }),
            new Pizza("Chicken Parmesan", new[]
            {
                Ingredients.CremeFraiche, Ingredients.Mozzarella, Ingredients.PouletRoti, Ingredients.Tomate, Ingredients.Parmigiano
            }),
            new Pizza("Végétarienne", new[]
            {
                Ingredients.SauceTomate, Ingredients.Mozzarella, Ingredients.Champignon, Ingredients.OignonRouge, Ingredients.PoivronVert, Ingredients.Tomate, Ingredients.OliveNoire
            }),
            new Pizza("Hawaïenne Jambon", new[]
            {
                Ingredients.SauceTomate, Ingredients.Mozzarella, Ingredients.Jambon, Ingredients.Ananas
            }),
        };
    }

    public record Pizza(string Name, Ingredient[] Ingredients);
}
