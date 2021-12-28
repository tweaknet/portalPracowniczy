using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class GetUserLoginRequest : IRequest<GetUserLoginResponse>
    {
        public string Name { get; set; }
        //public string Login { get; set; }
        //public string Password { get; set; }
    }
}
