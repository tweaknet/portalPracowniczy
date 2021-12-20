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
    public class ValidateUserHandler : IRequestHandler<ValidateUserRequest, ValidateUserResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public ValidateUserHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<ValidateUserResponse> Handle(ValidateUserRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUserLoginQuery()
            {
                Login = request.Login
            };
            var users = await this.queryExecutor.Execute(query);
            var mappedUserLogin = this.mapper.Map<Domain.Models.User>(users);
            var response = new ValidateUserResponse()
            {
                Data = mappedUserLogin
            };
            return response;
        }
    }
}
