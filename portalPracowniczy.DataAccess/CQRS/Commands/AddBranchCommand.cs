using portalPracowniczy.DataAccess.Entities;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Commands
{
    public class AddBranchCommand : CommandBase<Branch, Branch>
    {
        public override async Task<Branch> Execute(PortalStorageContext context)
        {
            await context.Branch.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
