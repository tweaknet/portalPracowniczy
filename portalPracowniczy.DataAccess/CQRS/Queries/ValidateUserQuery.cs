using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    internal class ValidateUserQuery : QueryBase<List<User>>
    {
        public string Login { get; set; }
        public override Task<List<User>> Execute(PortalStorageContext context)
        {
            return context.Users.Where(x => x.Login == this.Login).ToListAsync();
        }
    }
}
