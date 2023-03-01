using PizzaPrice;

namespace PizzaPriceTests
{
    public class PizzaPriceServiceTests
    {
        [Fact]
        public void When_OnlyTomatoSauce_Should_ReturnRightPrice()
        {
            // Arrange 
            var ingredient = "Sauce Tomate";
            var ingredientPrice = 1;
            var pizzaPriceService = new PizzaPriceService();

            // Act
            var price = pizzaPriceService.GetIngredientPrice(ingredient);

            // Assert
            Assert.Equal(ingredientPrice, price);
        }

        [Fact]
        public void When_OnlyBarbecueSauce_Should_ReturnRightPrice()
        {
            // Arrange 
            var ingredient = "Sauce Barbecue";
            var ingredientPrice = 2;
            var pizzaPriceService = new PizzaPriceService();

            // Act
            var price = pizzaPriceService.GetIngredientPrice(ingredient);

            // Assert
            Assert.Equal(ingredientPrice, price);
        }

        [Fact]
        public void When_IngredientDoesNotExist_Should_ThrowArgumentException()
        {
            // Arrange
            var ingredient = "Caviar";
            var pizzaPriceService = new PizzaPriceService();

            // Act 
            Assert.Throws<ArgumentException>(() => pizzaPriceService.GetIngredientPrice(ingredient));
        }
        
        [Fact]
        public void When_PizzaContainsAnIngredientThatDoesNotExist_Should_ThrowApplicationException()
        {
            // Arrange
            var pizzaPriceService = new PizzaPriceService();

            // Act 
            Assert.Throws<ApplicationException>(() => pizzaPriceService.GetPizzaPrice("Raclette"));
        }

        [Fact]
        public void When_MultipleIngredients_ShouldReturnRightPrice()
        {
            // Arrange 
            string[] ingredients = { "Crème fraiche", "Emmental" };
            var ingredientPrice = 3.5;
            var pizzaPriceService = new PizzaPriceService();

            // Act
            var price = ingredients.Sum(pizzaPriceService.GetIngredientPrice);

            // Assert
            Assert.Equal(ingredientPrice, price);
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