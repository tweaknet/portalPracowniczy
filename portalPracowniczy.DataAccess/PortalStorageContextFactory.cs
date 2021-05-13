using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess
{
    class PortalStorageContextFactory : IDesignTimeDbContextFactory<PortalStorageContext>
    {
        public PortalStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PortalStorageContext>();
            //optionsBuilder.UseSqlServer("Provider=SQLNCLI11;Data Source=.\\sqlexpress;Integrated Security=SSPI;Initial Catalog=WebApp");
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=portal;Integrated Security=True");
            return new PortalStorageContext(optionsBuilder.Options);
        }
    }
}
