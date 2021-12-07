using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class GetBranchesQuery : QueryBase<List<Branch>>
    {
        public override Task<List<Branch>> Execute(PortalStorageContext context)
        {
            return context.Branch.ToListAsync();
        }
    }
}
