namespace PizzaPrice
{
    public static class Ingredients
    {
        public static Ingredient SauceTomate = new("Sauce Tomate", 1);
        public static Ingredient SauceBarbecue = new("Sauce Barbecue", 2);
        public static Ingredient CremeFraiche = new("Crème fraiche", 1.5);
        public static Ingredient SauceSamourai = new("Sauce Samuraï", 1);
        public static Ingredient PouletRoti = new("Poulet rôti", 6);
        public static Ingredient EmmietteDeBoeuf = new("Emmiétté de boeuf", 4.5);
        public static Ingredient Merguez = new("Merguez", 5);
        public static Ingredient Jambon = new("Jambon", 4.5);
        public static Ingredient SaucissePepperoni = new("Saucisse Pepperoni", 6);
        public static Ingredient Lardon = new("Lardons", 5.5);
        public static Ingredient Saumon = new("Saumon fumé", 6);
        public static Ingredient Champignon = new("Champignons", 2);
        public static Ingredient OignonRouge = new("Oignons rouges", 3.5);
        public static Ingredient OliveNoire = new("Olives noires", 3);
        public static Ingredient PoivronVert = new("Poivrons verts", 3);
        public static Ingredient PommeDeTerre = new("Pomme de terre", 0);
        public static Ingredient Tomate = new("Tomates", 3);
        public static Ingredient Miel = new("Miel", 5);
        public static Ingredient Ananas = new("Ananas", 5);
        public static Ingredient Mozzarella = new("Mozzarella", 2);
        public static Ingredient FromageDeChevre = new("Fromage de chèvre", 4);
        public static Ingredient Emmental = new("Emmental", 2);
        public static Ingredient FourmeDAmbert = new("Fourme d'Ambert", 4);
        public static Ingredient FromageRaclette = new("Fromage raclette", 4);
        public static Ingredient Parmigiano = new("Parmigiano", 5);
    }

    public class Ingredient
    {
        private readonly double _price;
        public string Name { get; }

        public Ingredient(string name, double price)
        {
            Name = name;
            _price = price;
        }

        public double GetPrice()
        {
            if (_price == 0)
            {
                throw new ApplicationException($"L'ingrédient {Name} n'a pas de prix");
            }
            return _price;
        }
    }
}