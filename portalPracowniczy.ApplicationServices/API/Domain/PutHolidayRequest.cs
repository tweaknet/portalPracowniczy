using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using System;

namespace portalPracowniczy.Controllers
{
    public class PutHolidayRequest : IRequest<PutHolidayResponse>
    {
        public int IdHolidayType { get; set; }
        public DateTime Data { get; set; }
        public int IdUser { get; set; }
    }
}