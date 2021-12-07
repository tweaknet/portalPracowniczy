using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess.CQRS;
using portalPracowniczy.DataAccess.CQRS.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    public class DeleteHolidayHandler : IRequestHandler<DeleteHolidayRequest, DeleteHolidayResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;
        public DeleteHolidayHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<DeleteHolidayResponse> Handle(DeleteHolidayRequest request, CancellationToken cancellationToken)
        {
            var holiday = this.mapper.Map<DataAccess.Entities.Holiday>(request);
            var command = new DeleteHolidayCommand()
            {
                Parameter = holiday
            };
            var holidayFromDB = await this.commandExecutor.Execute(command);

            return new DeleteHolidayResponse()
            {
                Data = this.mapper.Map<API.Domain.Models.Holiday>(holidayFromDB)
            };
        }
    }
}
