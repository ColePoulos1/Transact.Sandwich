using Transact.Sandwich.Factory;
using Transact.Sandwich.Factory.Interface;

namespace Transact.Sandwich.Test
{
    public class SandwichFactoryTests
    {
        [Fact]
        public void ItalianSandwichCreationWorks()
        {
            ISandwichFactory factory = new SandwichFactory();
            Model.Sandwich sandwich = factory.CreateItalianSandwich();

            Assert.Equal("Salami", sandwich.Steps.ElementAt(1).Ingredients.First().Name);
            Assert.Equal(6.20M, sandwich.SubTotalCost);
        }

        [Fact]
        public void VeggieSandwichCreationWorks()
        {
            ISandwichFactory factory = new SandwichFactory();
            Model.Sandwich sandwich = factory.CreateVeggieSandwich();

            Assert.Equal("Sourdough", sandwich.Steps.ElementAt(0).Ingredients.First().Name);
            Assert.Equal(2.55M, sandwich.SubTotalCost);
        }
    }
}