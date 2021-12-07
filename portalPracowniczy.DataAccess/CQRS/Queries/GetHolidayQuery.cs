using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class GetHolidayQuery : QueryBase<Holiday>
    {
        public int Id { get; set; }
        public override async Task<Holiday> Execute(PortalStorageContext context)
        {
            var holiday = await context.Holidays.FirstOrDefaultAsync(x => x.Id == this.Id);
            return holiday;
        }
    }
}
