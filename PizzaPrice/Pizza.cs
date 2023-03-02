namespace PizzaPrice
{
    public abstract class PizzaClass
    {
        private readonly Ingredient[] _ingredients;
        public string Name { get; }

        protected PizzaClass(string name, Ingredient[] ingredients)
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
