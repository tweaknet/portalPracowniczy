using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class GetBranchQuery : QueryBase<Branch>
    {
        public int Id { get; set; }
        public override async Task<Branch> Execute(PortalStorageContext context)
        {
            var branch = await context.Branch.FirstOrDefaultAsync(x => x.Id == this.Id);
            return branch;
        }
    }
}
