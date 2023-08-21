namespace Transact.Sandwich.Model
{
    public abstract class Step
    {
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public decimal Surcharge { get; set; }
        public abstract void Process();
    }

    public class Prepare : Step
    {
        public override void Process()
        {
            if (Ingredients.Any())
                Console.WriteLine($"Preparing the {string.Join("and", Ingredients.Select(x => x.Name))}...");
            else
                Console.WriteLine("Nothing to prepare!");
        }
    }

    public class Apply : Step
    {
        public override void Process()
        {
            if (Ingredients.Any())
                Console.WriteLine($"Applying the {string.Join("and", Ingredients.Select(x => x.Name))}...");
            else
                Console.WriteLine("Nothing to apply!");
        }
    }

    public class Add : Step
    {
        public override void Process()
        {
            if (Ingredients.Any())
                Console.WriteLine($"Adding the {string.Join("and", Ingredients.Select(x => x.Name))}...");
            else
                Console.WriteLine("Nothing to add!");
        }
    }
}
