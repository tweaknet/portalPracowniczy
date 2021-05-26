﻿using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.CQRS.Queries
{
    public class GetUsersQuery : QueryBase<List<User>>
    {
        public int Id { get; set; }
        public override Task<List<User>> Execute(PortalStorageContext context)
        {
            return context.Users.ToListAsync();
        }
    }
}