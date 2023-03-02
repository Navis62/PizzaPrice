using System.Reflection;

namespace PizzaPrice
{
    public class PizzaPriceService
    {
        public double GetPizzaPrice(string name)
        {
            var pizzaList = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.Namespace == "PizzaPrice.Pizzas")
                .Select(pizza => Activator.CreateInstance(pizza) as PizzaClass);

            try
            {
                var pizza = pizzaList.Single(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
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
