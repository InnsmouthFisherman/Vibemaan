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
    }
}
