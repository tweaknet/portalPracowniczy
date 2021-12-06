using MediatR;
using System;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class GetHolidaysRequest : IRequest<GetHolidaysResponse>
    {
        public int Id { get; set; }
        public int IdHolidayType { get; set; }
        public DateTime Data { get; set; }
        public int IdUser { get; set; }
    }
}