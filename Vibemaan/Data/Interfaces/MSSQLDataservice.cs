using System.Composition;
using Microsoft.EntityFrameworkCore;

namespace Vibemaan.Data.Interfaces
{
    public class MSSQLDataservice(ApplicationDbContext context) : IDataService
    {
        public IEnumerable<Composition> GetItems()
        {
            return context.Compositions.ToArray();
        }

        public async Task SaveAsync(Composition comp)
        {
            await context.Compositions.AddAsync(comp);
            await context.SaveChangesAsync();
        }
    }
}
