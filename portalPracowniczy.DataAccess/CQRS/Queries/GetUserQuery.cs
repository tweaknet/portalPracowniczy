using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class GetUserQuery : QueryBase<User>
    {
        public int Id { get; set; }
        public override async Task<User> Execute(PortalStorageContext context)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == this.Id);
            return user;
        }
    }
}
