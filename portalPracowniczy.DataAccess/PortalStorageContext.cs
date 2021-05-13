using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess
{
    class PortalStorageContext : DbContext
    {
        public PortalStorageContext(DbContextOptions<PortalStorageContext> opt) : base(opt)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
    }
}
