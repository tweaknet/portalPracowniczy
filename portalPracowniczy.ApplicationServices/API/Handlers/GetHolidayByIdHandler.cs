using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
using portalPracowniczy.DataAccess.CQRS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    class GetHolidayByIdHandler : IRequestHandler<GetHolidayByIdRequest, GetHolidayByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetHolidayByIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetHolidayByIdResponse> Handle(GetHolidayByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUserQuery()
            {
                Id = request.UserId
            };
            var holiday = await this.queryExecutor.Execute(query);
            var mappedholiday = this.mapper.Map<Domain.Models.Holiday>(holiday);
            var response = new GetHolidayByIdResponse()
            {
                UserId = mappedholiday
            };
            return response;
        }
    }
}
