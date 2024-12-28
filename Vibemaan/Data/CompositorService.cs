using Vibemaan.Data.Interfaces;

namespace Vibemaan.Data
{
    public class CompositorService : ICompositorService
    {
        private static IEnumerable<Compositor> items = new List<Compositor>
        {
        new Compositor { Id = 0, Name = "Bathory"},
        new Compositor { Id = 1, Name = "Burzum"},
        new Compositor { Id = 2, Name = "Death"},
        };
        public IEnumerable<Compositor> GetItems()
        {
            return items;
        }
    }
}
