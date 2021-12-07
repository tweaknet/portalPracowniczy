using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess.CQRS;
using portalPracowniczy.DataAccess.CQRS.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    internal class DeleteBranchHandler : IRequestHandler<DeleteBranchByIdRequest, DeleteBranchByIdResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;
        public DeleteBranchHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<DeleteBranchByIdResponse> Handle(DeleteBranchByIdRequest request, CancellationToken cancellationToken)
        {
            var branch = this.mapper.Map<DataAccess.Entities.Branch>(request);
            var command = new DeleteBranchCommand()
            {
                Parameter = branch
            };
            var branchFromDB = await this.commandExecutor.Execute(command);

            return new DeleteBranchByIdResponse()
            {
                Data = this.mapper.Map<API.Domain.Models.Branch>(branchFromDB)
            };
        }
    }
}
