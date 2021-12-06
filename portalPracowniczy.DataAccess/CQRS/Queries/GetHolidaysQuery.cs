using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class GetHolidaysQuery : QueryBase<List<Holiday>>
    {
        public int IdUser { get; set; }
        public override Task<List<Holiday>> Execute(PortalStorageContext context)
        {
            return context.Holidays.Where(x => x.IdUser == this.IdUser).ToListAsync();
        }
    }
}
