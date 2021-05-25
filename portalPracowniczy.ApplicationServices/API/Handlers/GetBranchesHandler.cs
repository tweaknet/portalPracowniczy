using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
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
        private readonly IRepository<Branch> branchRepository;
        private readonly IMapper mapper;

        public GetBranchesHandler(IRepository<DataAccess.Entities.Branch> branchRepository, IMapper mapper)
        {
            this.branchRepository = branchRepository;
            this.mapper = mapper;
        }
        public async Task<GetBranchesResponse> Handle(GetBranchesRequest request, CancellationToken cancellationToken)
        {
            var branches = await this.branchRepository.GetAll();
            var mappedBranches = this.mapper.Map<List<Domain.Models.Branch>>(branches);
            var response = new GetBranchesResponse()
            {
                Data = mappedBranches
            };
            return response;
        }
    }
}
