using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class GetUsersRequest : IRequest<GetUsersResponse> 
    {
        public string Name { get; set; }
    }
}
