using AutoMapper;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.Mappings
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            this.CreateMap<AddUserRequest, User>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Login, y => y.MapFrom(z => z.Login))
                .ForMember(x => x.IdBranch, y => y.MapFrom(z => z.IdBranch))
                .ForMember(x => x.Password, y => y.MapFrom(z => z.Password));

            this.CreateMap<User, API.Domain.Models.User>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));

        }
    }
}
