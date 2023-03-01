namespace PizzaPrice
{
    public static class Reference
    {
        public static List<Ingredient> Ingredients { get; set; } = new()
        {
            new Ingredient("Sauce Tomate", 1),
            new Ingredient("Sauce Barbecue", 2),
            new Ingredient("Crème fraiche", 1.5),
            new Ingredient("Sauce Samuraï", 1),
            new Ingredient("Poulet rôti", 6),
            new Ingredient("Emmiétté de boeuf", 4.5),
            new Ingredient("Merguez", 5),
            new Ingredient("Jambon", 4.5),
            new Ingredient("Saucisse Pepperoni", 6),
            new Ingredient("Lardons", 5.5),
            new Ingredient("Saumon fumé", 6),
            new Ingredient("Champignons", 2),
            new Ingredient("Oignons rouges", 3.5),
            new Ingredient("Olives noires", 3),
            new Ingredient("Poivrons verts", 3),
            new Ingredient("Tomates", 3),
            new Ingredient("Miel", 5),
            new Ingredient("Ananas", 5),
            new Ingredient("Mozzarella", 2),
            new Ingredient("Fromage de chèvre", 4),
            new Ingredient("Emmental", 2),
            new Ingredient("Fourme d'Ambert", 4),
            new Ingredient("Fromage raclette", 4),
            new Ingredient("Parmigiano", 5),
        };

        public static List<Pizza> Pizzas { get; set; } = new()
        {
            new Pizza("4 Fromages base crème", new[] { "Crème fraiche", "Mozzarella", "Fromage de chèvre", "Emmental", "Fourme d'Ambert" }),
            new Pizza("4 Fromages base tomate", new[] { "Sauce Tomate", "Mozzarella", "Fromage de chèvre", "Emmental", "Fourme d'Ambert" }),
            new Pizza("BPM", new[] { "Sauce Barbecue", "Mozzarella", "Emmiétté de boeuf", "Poulet rôti", "Merguez" }),
            new Pizza("Pepperoni Lovers", new[] { "Sauce Tomate", "Mozzarella", "Saucisse Pepperoni" }),
            new Pizza("Queen", new[] { "Sauce Tomate", "Mozzarella", "Jambon", "Champignons" }),
            new Pizza("Montagnarde", new[] { "Crème fraiche", "Mozzarella", "Jambon", "Fromage raclette", "Champignons" }),
            new Pizza("Suprême", new[] { "Sauce Tomate", "Mozzarella", "Emmiétté de boeuf", "Saucisse Pepperoni", "Champignons", "Oignons rouges", "Poivrons verts" }),
            new Pizza("Raclette", new [] { "Crème fraiche", "Mozzarella", "Pommes de terre", "Lardons", "Fromage raclette" }),
            new Pizza("Chèvre Miel", new[] { "Crème fraiche", "Mozzarella", "Fromage de chèvre", "Miel" }),
            new Pizza("Nordique", new[] { "Crème fraiche", "Mozzarella", "Saumon fumé" }),
            new Pizza("Campagnarde", new[] { "Crème fraiche", "Mozzarella", "Lardons", "Oignons rouges", "Champignons" }),
            new Pizza("Samouraï", new[] { "Sauce Tomate", "Mozzarella", "Merguez", "Poulet rôti", "Oignons rouges", "Sauce Samouraï" }),
            new Pizza("Chicken Parmesan", new[] { "Crème fraiche", "Mozzarella", "Poulet rôti", "Tomates", "Parmigiano" }),
            new Pizza("Végétarienne", new[] { "Sauce Tomate", "Mozzarella", "Champignons", "Oignons rouges", "Poivrons verts", "Tomates", "Olives noires" }),
            new Pizza("Hawaïenne Jambon", new[] { "Sauce Tomate", "Mozzarella", "Jambon", "Ananas" }),
        };
    }
}
