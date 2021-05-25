using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    class GetUsersQuery : QueryBase<List<User>>
    {
        public int Id { get; set; }
        public override async Task<List<User>> Execute(PortalStorageContext context)
        {
            var user = await context.Users.ToListAsync();
            return user;
        }
    }
}
