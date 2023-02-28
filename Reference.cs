namespace PizzaPrice
{
    public static class Reference
    {
        public static List<Ingredient> Ingredients { get; set; } = new()
        {
            new() {Name = "Sauce Tomate", Price = 1},
            new() {Name = "Sauce Barbecue", Price = 2},
            new() {Name = "Crème fraiche", Price = 1.5},
            new() {Name = "Poulet rôti", Price = 6},
            new() {Name = "Emmiétté de boeuf", Price = 4.5},
            new() {Name = "Merguez", Price = 5},
            new() {Name = "Jambon", Price = 4.5},
            new() {Name = "Saucisse Pepperoni", Price = 6},
            new() {Name = "Lardons", Price = 5.5},
            new() {Name = "Saumon fumé", Price = 6},
            new() {Name = "Champignons", Price = 2},
            new() {Name = "Oignons rouges", Price = 3.5},
            new() {Name = "Olives noires", Price = 3},
            new() {Name = "Poivrons verts", Price = 3},
            new() {Name = "Tomates", Price = 3},
            new() {Name = "Miel", Price = 5},
            new() {Name = "Ananas", Price = 5},
            new() {Name = "Mozzarella", Price = 2},
            new() {Name = "Fromage de chèvre", Price = 4},
            new() {Name = "Emmental", Price = 2},
            new() {Name = "Fourme d'Ambert", Price = 4},
            new() {Name = "Fromage raclette", Price = 4},
            new() {Name = "Parmigiano", Price = 5},
        };

        public static List<Pizza> Pizzas { get; set; } = new()
        {
            new () { Name = "4 Fromages base crème", Ingredients = new[] { "Crème fraiche", "Mozzarella", "Fromage de chèvre", "Emmental", "Fourme d'Ambert" } },
            new () { Name = "4 Fromages base tomate", Ingredients = new[] { "Sauce Tomate", "Mozzarella", "Fromage de chèvre", "Emmental", "Fourme d'Ambert" } },
            new () { Name = "BPM", Ingredients = new[] { "Sauce Barbecue", "Mozzarella", "Emmiétté de boeuf", "Poulet rôti", "Merguez" } },
            new () { Name = "Pepperoni Lovers", Ingredients = new[] { "Sauce Tomate", "Mozzarella", "Saucisse Pepperoni" } },
            new () { Name = "Chèvre Miel", Ingredients = new[] { "Crème fraiche", "Mozzarella", "Fromage de chèvre", "Miel" } },
        };
    }
}
