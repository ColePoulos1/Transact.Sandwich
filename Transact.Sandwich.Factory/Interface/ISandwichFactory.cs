namespace Transact.Sandwich.Factory.Interface
{
    public interface ISandwichFactory
    {
        public Model.Sandwich CreateItalianSandwich();
        
        public Model.Sandwich CreateVeggieSandwich();
    }
}