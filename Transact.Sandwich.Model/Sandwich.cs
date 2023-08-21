namespace Transact.Sandwich.Model
{
    public class Sandwich
    {
        public IEnumerable<Step> Steps { get; set; } = new List<Step>();

        public decimal SubTotalCost {
            get => Steps.Sum(x => x.Surcharge + x.Ingredients.Sum(x => x.Price * x.Quantity)); 
        }

        public IEnumerable<Ingredient> GetIngredients()
            => Steps.SelectMany(x => x.Ingredients);

        public void ProcessCreation()
        {
            foreach (Step step in Steps)
            {
                step.Process();
            }

            Console.WriteLine($"Done! This sandwich will cost ${SubTotalCost} before tax.");
        }
    }
}