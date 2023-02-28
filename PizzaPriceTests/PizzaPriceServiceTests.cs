using PizzaPrice;

namespace PizzaPriceTests
{
    public class PizzaPriceServiceTests
    {
        private PizzaPriceService GetTarget()
        {
            return new PizzaPriceService();
        }

        [Fact]
        public void When_OnlyTomatoSauce_Should_ReturnRightPrice()
        {
            // Arrange 
            var ingredient = "Sauce Tomate";
            var pizzaPriceService = GetTarget();

            // Act
            var price = pizzaPriceService.GetIngredientPrice(ingredient);

            // Assert
            Assert.Equal(1, price);
        }

        [Fact]
        public void When_OnlyBarbecueSauce_Should_ReturnRightPrice()
        {
            // Arrange 
            var ingredient = "Sauce Barbecue";
            var pizzaPriceService = GetTarget();

            // Act
            var price = pizzaPriceService.GetIngredientPrice(ingredient);

            // Assert
            Assert.Equal(2, price);
        }

        [Fact]
        public void When_IngredientDoesNotExist_Should_Return0()
        {
            // Arrange
            var ingredient = "Caviar";
            var pizzaPriceService = GetTarget();

            // Act
            var price = pizzaPriceService.GetIngredientPrice(ingredient);

            // Assert
            Assert.Equal(0, price);
        }

        [Fact]
        public void When_MultipleIngredients_ShouldReturnRightPrice()
        {
            // Arrange 
            string[] ingredients = { "Crème fraiche", "Emmental" };
            var pizzaPriceService = GetTarget();

            // Act
            var price = ingredients.Sum(pizzaPriceService.GetIngredientPrice);

            // Assert
            Assert.Equal(3.5, price);
        }

        [Fact]
        public void When_PizzaChevreMiel_ShouldReturnRightPrice()
        {
            // Arrange 
            var pizzaPriceService = GetTarget();

            // Act
            var price = pizzaPriceService.GetPizzaPrice("Chèvre Miel");

            // Assert
            Assert.Equal(12.5, price);
        }

        [Fact]
        public void When_Pizza4FromagesBaseTomate_ShouldReturnRightPrice()
        {
            // Arrange 
            var pizzaPriceService = GetTarget();

            // Act
            var price = pizzaPriceService.GetPizzaPrice("4 Fromages base tomate");

            // Assert
            Assert.Equal(13, price);
        }

        [Fact]
        public void When_PizzaDoesNotExist_Should_ThrowArgumentException()
        {
            // Arrange
            var pizzaPriceService = GetTarget();

            // Act 
            Assert.Throws<ArgumentException>(() => pizzaPriceService.GetPizzaPrice("Chocolat Fruits de mer"));
        }
    }
}