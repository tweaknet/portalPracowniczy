using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class GetUserByIdRequest : IRequest<GetUsersByIdResponse>
    {
        public int UserId { get; set; }
    }
}
