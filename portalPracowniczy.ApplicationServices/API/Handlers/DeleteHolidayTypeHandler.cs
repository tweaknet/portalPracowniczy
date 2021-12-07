using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess.CQRS;
using portalPracowniczy.DataAccess.CQRS.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    public class DeleteHolidayTypeHandler : IRequestHandler<DeleteHolidayTypeByIdRequest, DeleteHolidayTypeByIdResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;
        public DeleteHolidayTypeHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<DeleteHolidayTypeByIdResponse> Handle(DeleteHolidayTypeByIdRequest request, CancellationToken cancellationToken)
        {
            var holidayType = this.mapper.Map<DataAccess.Entities.HolidayType>(request);
            var command = new DeleteHolidayTypeCommand()
            {
                Parameter = holidayType
            };
            var holidayTypeFromDB = await this.commandExecutor.Execute(command);

            return new DeleteHolidayTypeByIdResponse()
            {
                Data = this.mapper.Map<API.Domain.Models.HolidayType>(holidayTypeFromDB)
            };
        }
    }
}
