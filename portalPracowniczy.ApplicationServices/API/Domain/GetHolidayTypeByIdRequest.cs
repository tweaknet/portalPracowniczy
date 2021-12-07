using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class GetHolidayTypeByIdRequest : IRequest<GetHolidayTypeByIdResponse>
    {
        public int Id { get; set; }
    }
}
