using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class ValidateUserRequest : IRequest<ValidateUserResponse>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
