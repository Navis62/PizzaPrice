using PizzaPrice;

namespace PizzaPriceTests
{
    public class PizzaPriceServiceTests
    {
        [Fact]
        public void When_PizzaContainsAnIngredientThatDoesNotExist_Should_ThrowApplicationException()
        {
            // Arrange
            var pizzaPriceService = new PizzaPriceService();

            // Act 
            Assert.Throws<ApplicationException>(() => pizzaPriceService.GetPizzaPrice("Raclette"));
        }

        [Fact]
        public void When_PizzaChevreMiel_ShouldReturnRightPrice()
        {
            // Arrange 
            var pizzaPriceService = new PizzaPriceService();
            var pizzaPrice = 12.5;

            // Act
            var price = pizzaPriceService.GetPizzaPrice("Chèvre Miel");

            // Assert
            Assert.Equal(pizzaPrice, price);
        }

        [Fact]
        public void When_Pizza4FromagesBaseTomate_ShouldReturnRightPrice()
        {
            // Arrange 
            var pizzaPriceService = new PizzaPriceService();
            var pizzaPrice = 13;

            // Act
            var price = pizzaPriceService.GetPizzaPrice("4 Fromages base tomate");

            // Assert
            Assert.Equal(pizzaPrice, price);
        }

        [Fact]
        public void When_PizzaDoesNotExist_Should_ThrowArgumentException()
        {
            // Arrange
            var pizzaPriceService = new PizzaPriceService();

            // Act 
            Assert.Throws<ArgumentException>(() => pizzaPriceService.GetPizzaPrice("Chocolat Fruits de mer"));
        }
    }
}