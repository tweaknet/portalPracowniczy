using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class GetHolidaysQuery : QueryBase<List<Holiday>>
    {
        public override Task<List<Holiday>> Execute(PortalStorageContext context)
        {
            return context.Holidays.ToListAsync();
        }
    }
}
