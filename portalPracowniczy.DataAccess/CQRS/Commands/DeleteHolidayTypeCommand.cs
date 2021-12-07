using portalPracowniczy.DataAccess.Entities;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Commands
{
    public class DeleteHolidayTypeCommand : CommandBase<HolidayType, HolidayType>
    {
        public override async Task<HolidayType> Execute(PortalStorageContext context)
        {
            context.HolidayTypes.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
