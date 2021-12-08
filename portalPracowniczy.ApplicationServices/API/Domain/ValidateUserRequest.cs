using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class ValidateUserRequest : IRequest<ValidateUserResponse>
    {
        public string User { get; set; }
        public string Password { get; set; }
    }
}
