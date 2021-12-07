using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class DeleteHolidayRequest : IRequest<DeleteHolidayResponse>
    {
        public int Id { get; set; }
    }
}
