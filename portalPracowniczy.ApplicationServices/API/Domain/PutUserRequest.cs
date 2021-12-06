using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class PutUserRequest : IRequest<PutUserResponse>
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IdBranch { get; set; }
    }
}
