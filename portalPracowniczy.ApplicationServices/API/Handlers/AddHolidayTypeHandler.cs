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
    internal class AddHolidayTypeHandler : IRequestHandler<AddHolidayTypeRequest, AddHolidayTypeResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;
        public AddHolidayTypeHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }
        public async Task<AddHolidayTypeResponse> Handle(AddHolidayTypeRequest request, CancellationToken cancellationToken)
        {
            var holidayType = this.mapper.Map<HolidayType>(request);
            var command = new AddHolidayTypeCommand() { Parameter = holidayType };
            var holidayTypeFromDb = await this.commandExecutor.Execute(command);
            return new AddHolidayTypeResponse()
            {
                Data = this.mapper.Map<Domain.Models.HolidayType>(holidayTypeFromDb)
            };
        }
    }
}
