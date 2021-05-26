using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
using portalPracowniczy.DataAccess.CQRS.Queries;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    public class GetBranchesHandler : IRequestHandler<GetBranchesRequest, GetBranchesResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetBranchesHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetBranchesResponse> Handle(GetBranchesRequest request, CancellationToken cancellationToken)
        {
            var query = new GetBranchesQuery();
            var branches = await this.queryExecutor.Execute(query);
            var mappedBranches = this.mapper.Map<List<Domain.Models.Branch>>(branches);
            var response = new GetBranchesResponse()
            {
                Data = mappedBranches
            };
            return response;
        }
    }
}
