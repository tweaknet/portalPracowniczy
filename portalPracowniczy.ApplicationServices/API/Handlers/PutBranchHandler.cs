using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess.CQRS;
using portalPracowniczy.DataAccess.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    public class PutBranchHandler : IRequestHandler<PutBranchRequest, PutBranchResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;
        public PutBranchHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }
        public async Task<PutBranchResponse> Handle(PutBranchRequest request, CancellationToken cancellationToken)
        {
            var branch = this.mapper.Map<DataAccess.Entities.Branch>(request);
            var command = new PutBranchCommand()
            {
                Parameter = branch
            };
            var branchUpdated = await this.commandExecutor.Execute(command);

            return new PutBranchResponse()
            {
                Data = this.mapper.Map<API.Domain.Models.Branch>(branchUpdated)
            };
        }
    }
}
