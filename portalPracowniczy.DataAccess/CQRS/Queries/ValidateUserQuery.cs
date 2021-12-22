using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class ValidateUserQuery : QueryBase<User>
    {
        public string Login { get; set; }
        public override Task<User> Execute(PortalStorageContext context)
        {
            return context.Users.FirstOrDefaultAsync(x => x.Login == this.Login);
        }
    }
}
