using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Commands
{
    public class DeleteBranchCommand : CommandBase<Branch, Branch>
    {
        public override async Task<Branch> Execute(PortalStorageContext context)
        {
            context.Branch.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
