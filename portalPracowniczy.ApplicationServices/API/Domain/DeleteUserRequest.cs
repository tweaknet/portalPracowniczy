using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class DeleteUserRequest : IRequest<DeleteUserResponse>
    {
        public int UserId { get; set; }
    }
}
