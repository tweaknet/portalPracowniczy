using portalPracowniczy.DataAccess.Entities;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Commands
{
    public class DeleteHolidayCommand : CommandBase<Holiday, Holiday>
    {
        public override async Task<Holiday> Execute(PortalStorageContext context)
        {
            context.Holidays.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
