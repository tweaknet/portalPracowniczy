using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
using portalPracowniczy.DataAccess.CQRS.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    public class GetUsersLoginHandler : IRequestHandler<GetUserLoginRequest, GetUserLoginResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetUsersLoginHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetUserLoginResponse> Handle(GetUserLoginRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUserLoginQuery()
            {
                Login = request.Name
            };
            var users = await this.queryExecutor.Execute(query);
            var mappedUserLogin = this.mapper.Map<Domain.Models.User>(users);
            var response = new GetUserLoginResponse()
            {
                Data = mappedUserLogin
            };
            return response;
        }
    }
}
