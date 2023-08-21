namespace Transact.Sandwich.Model
{
    public abstract class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class Bread : Ingredient { }
    public class Meat : Ingredient { }
    public class Cheese : Ingredient { }
    public class Vegetable : Ingredient { }
    public class Condiment : Ingredient { }
}
