using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
using portalPracowniczy.DataAccess.CQRS;
using portalPracowniczy.DataAccess.CQRS.Commands;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    public class AddHolidayHandler : IRequestHandler<AddHolidayRequest, AddHolidayResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;
        public AddHolidayHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddHolidayResponse> Handle(AddHolidayRequest request, CancellationToken cancellationToken)
        {
            var holiday = this.mapper.Map<Holiday>(request);
            var command = new AddHolidayCommand() { Parameter = holiday };
            var holidayFromDb = await this.commandExecutor.Execute(command);
            return new AddHolidayResponse()
            {
                Data = this.mapper.Map<Domain.Models.Holiday>(holidayFromDb)
            };
        }
    }
}
