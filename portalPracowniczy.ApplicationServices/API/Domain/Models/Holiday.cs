using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Domain.Models
{
    public class Holiday
    {
        public int IdHolidayType { get; set; }
        public DateTime Data { get; set; }
        public int IdUser { get; set; }
    }
}
