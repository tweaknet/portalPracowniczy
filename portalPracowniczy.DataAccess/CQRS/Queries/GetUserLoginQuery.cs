using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class GetUserLoginQuery : QueryBase<User>
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public override async Task<User> Execute(PortalStorageContext context)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Name == this.Name);
        }
    }
}
