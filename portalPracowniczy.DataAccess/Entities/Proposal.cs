using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.Entities
{
    class Proposal : EntityBase
    {
        public int IdStatus { get; set; }
        public int IdUser { get; set; }
        public DateTime date { get; set; }
        public int IdHolidayType { get; set; }
        public DateTime curentDate { get; set; }
        public List<User> Users { get; set; }
    }
}
