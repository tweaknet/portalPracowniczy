using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
using portalPracowniczy.DataAccess.CQRS.Queries;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    class GetUserByIdHandler : IRequestHandler<GetUserByIdRequest, GetUsersByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetUserByIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetUsersByIdResponse> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUserQuery()
            {
                Id = request.UserId
            };
            var user = await this.queryExecutor.Execute(query);
            var mappedUser = this.mapper.Map<Domain.Models.User>(user);
            var response = new GetUsersByIdResponse()
            {
                Data = mappedUser
            };
            return response;
        }
    }
}
