using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
using portalPracowniczy.DataAccess.CQRS.Queries;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    internal class GetBranchByIdHandler : IRequestHandler<GetBranchByIdRequest, GetBranchByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetBranchByIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetBranchByIdResponse> Handle(GetBranchByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetBranchQuery()
            {
                Id = request.Id
            };
            var branch = await this.queryExecutor.Execute(query);
            var mappedbranch = this.mapper.Map<Domain.Models.Branch>(branch);
            var response = new GetBranchByIdResponse()
            {
                Data = mappedbranch
            };
            return response;
        }
    }
}
