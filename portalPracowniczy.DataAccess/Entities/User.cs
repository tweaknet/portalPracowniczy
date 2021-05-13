using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.Entities
{
    class User
    {
        public int Id { get; set; }
        public int IdERP { get; set; }
        public int IdRCP { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public int IdPosition { get; set; }
        public int IdBranch { get; set; }
    }
}
