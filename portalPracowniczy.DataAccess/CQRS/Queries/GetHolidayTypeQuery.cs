using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class GetHolidayTypeQuery : QueryBase<List<HolidayType>>
    {
        public override Task<List<HolidayType>> Execute(PortalStorageContext context)
        {
            return context.HolidayTypes.ToListAsync();
        }
    }
}
