using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class GetBranchesQuery : QueryBase<List<Branch>>
    {
        public string Name { get; set; }
        public override Task<List<Branch>> Execute(PortalStorageContext context)
        {
            return context.Branch.ToListAsync();
        }
    }
}
