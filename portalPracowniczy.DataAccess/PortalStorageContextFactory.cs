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
            //optionsBuilder.UseSqlServer("Provider=srv3;Data Source=srv3\\mssql;Integrated Security=SSPI;Initial Catalog=WebApp");
            optionsBuilder.UseSqlServer("Data Source=srv3\\MSSQL;Initial Catalog=portal;Integrated Security=True");
            //optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=portal;Integrated Security=True");
            return new PortalStorageContext(optionsBuilder.Options);
        }
    }
}
