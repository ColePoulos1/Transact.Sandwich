using Transact.Sandwich.Factory.Interface;
using Transact.Sandwich.Model;

namespace Transact.Sandwich.Factory
{
    public class SandwichFactory: ISandwichFactory
    {
        public Model.Sandwich CreateItalianSandwich()
        {
            var sandwich = new Model.Sandwich
            {
                Steps = new List<Step>
                { 
                    new Prepare
                    {
                        Ingredients = new List<Ingredient>
                        { 
                            new Bread {Name = "Baguette", Price = 1.00M , Quantity = 1} 
                        }
                    },
                    new Apply
                    {
                        Ingredients = new List<Ingredient>
                        { 
                            new Meat {Name = "Salami", Price = 1.50M , Quantity = 2},
                            new Cheese {Name = "Provolone", Price = 0.50M , Quantity = 2},
                        }
                    },
                    new Apply
                    {
                        Ingredients = new List<Ingredient>
                        {
                            new Vegetable {Name = "Lettuce", Price = 0.20M , Quantity = 1},
                            new Vegetable {Name = "Tomato", Price = 0.25M , Quantity = 3},
                        }
                    },
                    new Add
                    {
                        Ingredients = new List<Ingredient>
                        {
                            new Condiment {Name = "Mayonnaise", Price = 0.05M , Quantity = 5}
                        }
                    }
                }
            };

            sandwich.ProcessCreation();

            return sandwich;
        }

        public Model.Sandwich CreateVeggieSandwich()
        {
            var sandwich = new Model.Sandwich
            {
                Steps = new List<Step>
                {
                    new Prepare
                    {
                        Ingredients = new List<Ingredient>
                        {
                            new Bread {Name = "Sourdough", Price = 1.00M , Quantity = 1}
                        }
                    },
                    new Apply
                    {
                        Ingredients = new List<Ingredient>
                        {
                            new Vegetable {Name = "Lettuce", Price = 0.20M , Quantity = 1},
                            new Vegetable {Name = "Bell Pepper", Price = 0.25M , Quantity = 3},
                            new Vegetable {Name = "Onion", Price = 0.20M , Quantity = 2},
                        }
                    },
                    new Add
                    {
                        Ingredients = new List<Ingredient>
                        {
                            new Condiment {Name = "Mustard", Price = 0.05M , Quantity = 4}
                        }
                    }
                }
            };

            sandwich.ProcessCreation();

            return sandwich;
        }
    }
}