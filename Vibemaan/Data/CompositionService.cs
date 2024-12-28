using Vibemaan.Data.Interfaces;

namespace Vibemaan.Data
{
    public class CompositionService : IDataService
    {
        private static IEnumerable<Composition> items = new List<Composition>
        {
        new Composition { Id = 0, Name = "Blood fire death", Duration = 600},
        new Composition { Id = 1, Name = "Dunkelheit", Duration = 666},
        new Composition { Id = 2, Name = "Zombie ritual", Duration = 273},
        new Composition { Id = 3, Name = "Mutilation", Duration = 208},
        };
        public IEnumerable<Composition> GetItems() 
        {
            return items;
        }

        public Task SaveAsync(Composition comp)
        {
            throw new NotImplementedException();
        }
    }
}
