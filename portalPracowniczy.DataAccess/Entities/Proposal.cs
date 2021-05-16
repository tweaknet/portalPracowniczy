using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("jakisWaznyKlucz")]
        public int IdHolidayType { get; set; }
        public DateTime curentDate { get; set; }
    }
}
