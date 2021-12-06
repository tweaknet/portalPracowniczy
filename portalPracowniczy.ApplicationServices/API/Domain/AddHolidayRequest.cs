using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class AddHolidayRequest : IRequest<AddHolidayResponse>
    {
        public int HolidayId { get; set; }
        public int IdHolidayType { get; set; }
        public DateTime Data { get; set; }
        public int IdUser { get; set; }
    }
}
