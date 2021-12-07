using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Commands
{
    public class PutBranchCommand : CommandBase<Branch, Branch>
    {
        public override async Task<Branch> Execute(PortalStorageContext context)
        {
            context.Branch.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
