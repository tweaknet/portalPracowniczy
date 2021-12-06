using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Commands
{
    public class AddHolidayCommand : CommandBase<Holiday, Holiday>
    {
        public override async Task<Holiday> Execute(PortalStorageContext context)
        {
            await context.Holidays.AllAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
