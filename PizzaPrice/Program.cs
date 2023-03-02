using PizzaPrice;

Console.WriteLine("Hello, World!");

var pizzaPriceService = new PizzaPriceService();

var price = pizzaPriceService.GetPizzaPrice("Pepperoni Lovers");

