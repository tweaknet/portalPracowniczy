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

        public GetBranchesHandler(IRepository<DataAccess.Entities.Branch> branchRepository)
        {
            this.branchRepository = branchRepository;
        }
        public Task<GetBranchesResponse> Handle(GetBranchesRequest request, CancellationToken cancellationToken)
        {
            var branches = this.branchRepository.GetAll();
            var domainBranch = branches.Select(x => new Domain.Models.Branch()
            {
                IdSuperior = x.IdSuperior,
                Name = x.Name
            });
            var response = new GetBranchesResponse()
            {
                Data = domainBranch.ToList()
            };
            return Task.FromResult(response);
        }
    }
}
