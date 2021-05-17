using Microsoft.EntityFrameworkCore;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess
{
    public class PortalStorageContext : DbContext
    {
        public PortalStorageContext(DbContextOptions<PortalStorageContext> opt) : base(opt)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<HolidayType> HolidayTypes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Branch> Branch { get; set; }
    }
}
