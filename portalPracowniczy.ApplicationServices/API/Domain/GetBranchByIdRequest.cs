using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class GetBranchByIdRequest : IRequest<GetBranchByIdResponse>
    {
        public int Id { get; set; }
    }
}
