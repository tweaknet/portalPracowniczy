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
    public class GetHolidaysHandler : IRequestHandler<GetHolidaysRequest, GetHolidaysResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetHolidaysHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetHolidaysResponse> Handle(GetHolidaysRequest request, CancellationToken cancellationToken)
        {
            var query = new GetHolidaysQuery();
            var holidays = await this.queryExecutor.Execute(query);
            var mappedHolidays = this.mapper.Map<List<Domain.Models.Holiday>>(holidays);
            var response = new GetHolidaysResponse()
            {
                Data = mappedHolidays
            };
            return response;
        }
    }
}
