using System.Reflection;

namespace PizzaPrice
{
    public class PizzaPriceService
    {
        private readonly IEnumerable<PizzaClass?> _pizzas;

        public PizzaPriceService()
        {
           BuildPizzaList();
        }

        private static void BuildPizzaList()
        {
            _pizzas = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.Namespace == "PizzaPrice.Pizzas")
                .Select(pizza => Activator.CreateInstance(pizza) as PizzaClass);
        }

        public double GetPizzaPrice(string name)
        {
            try
            {
                var pizza = _pizzas.Single(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
                return pizza.GetPrice();
            }
            catch(ApplicationException exc)
            {
                throw new ApplicationException(exc.Message);
            }
            catch
            {
                throw new ArgumentException($"La pizza {name} n'existe pas");
            }
        }
    }
}
