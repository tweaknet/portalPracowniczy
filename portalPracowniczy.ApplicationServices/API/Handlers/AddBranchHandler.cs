using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess.CQRS;
using portalPracowniczy.DataAccess.CQRS.Commands;
using portalPracowniczy.DataAccess.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    internal class AddBranchHandler : IRequestHandler<AddBranchRequest, AddBranchResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;
        public AddBranchHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddBranchResponse> Handle(AddBranchRequest request, CancellationToken cancellationToken)
        {
            var branch = this.mapper.Map<Branch>(request);
            var command = new AddBranchCommand() { Parameter = branch };
            var branchFromDb = await this.commandExecutor.Execute(command);
            return new AddBranchResponse()
            {
                Data = this.mapper.Map<Domain.Models.Branch>(branchFromDb)
            };
        }
    }
}
