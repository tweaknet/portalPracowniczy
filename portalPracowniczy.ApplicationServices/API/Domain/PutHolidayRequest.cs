using MediatR;
using System;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class PutHolidayRequest : IRequest<PutHolidayResponse>
    {
        public int IdHolidayType { get; set; }
        public DateTime Data { get; set; }
        public int IdUser { get; set; }
    }
}