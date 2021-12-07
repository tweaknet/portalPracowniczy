using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class GetHolidayByIdRequest : IRequest<GetHolidayByIdResponse>
    {
        public int Id { get; set; }
    }
}