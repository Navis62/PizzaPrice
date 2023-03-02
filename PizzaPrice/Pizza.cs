namespace PizzaPrice
{
    public abstract class Pizza
    {
        private readonly Ingredient[] _ingredients;
        public string Name { get; }

        protected Pizza(string name, Ingredient[] ingredients)
        {
            Name = name;
            _ingredients = ingredients;
        }

        public double GetPrice()
        {
            return _ingredients.Sum(x => x.GetPrice());
        }
    }
}
