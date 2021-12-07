using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
using portalPracowniczy.DataAccess.CQRS.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    internal class GetHolidayTypeHandler : IRequestHandler<GetHolidayTypeRequest, GetHolidayTypeResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetHolidayTypeHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetHolidayTypeResponse> Handle(GetHolidayTypeRequest request, CancellationToken cancellationToken)
        {
            var query = new GetHolidayTypeQuery();
            var holidays = await this.queryExecutor.Execute(query);
            var mappedHolidays = this.mapper.Map<List<Domain.Models.HolidayType>>(holidays);
            var response = new GetHolidayTypeResponse()
            {
                Data = mappedHolidays
            };
            return response;
        }
    }
}
