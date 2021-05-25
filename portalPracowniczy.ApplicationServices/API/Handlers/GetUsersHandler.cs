using AutoMapper;
using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Handlers
{
    public class GetUsersHandler : IRequestHandler<GetUsersRequest, GetUsersResponse>
    {
        private readonly IRepository<User> userRepository;
        private readonly IMapper mapper;
        
        public GetUsersHandler(IRepository<DataAccess.Entities.User> userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<GetUsersResponse> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var users = await this.userRepository.GetAll();
            var mappedUsers = this.mapper.Map<List< Domain.Models.User>> (users);
            var response = new GetUsersResponse()
            {
                Data = mappedUsers
            };
            return response;
        }
    }
}
