namespace Vibemaan.Data.Interfaces
{
    public interface IDataService
    {
        IEnumerable<Composition> GetItems();
        Task SaveAsync(Composition composition);
    }
}
