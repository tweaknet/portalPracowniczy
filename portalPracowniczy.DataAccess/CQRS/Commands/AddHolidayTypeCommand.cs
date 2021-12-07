using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Commands
{
    public class AddHolidayTypeCommand : CommandBase<HolidayType, HolidayType>
    {
        public override async Task<HolidayType> Execute(PortalStorageContext context)
        {
            await context.HolidayTypes.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
