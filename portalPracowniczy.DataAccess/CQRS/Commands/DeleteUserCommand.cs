using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Commands
{
    public class DeleteUserCommand : CommandBase<User, User>
    {
        public override async Task<User> Execute(PortalStorageContext context)
        {
            context.Users.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
