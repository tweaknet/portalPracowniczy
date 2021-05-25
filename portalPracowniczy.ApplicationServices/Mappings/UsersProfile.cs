using AutoMapper;
using portalPracowniczy.ApplicationServices.API.Domain.Models;
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
            this.CreateMap<portalPracowniczy.DataAccess.Entities.User, User>()
    .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
    .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
        }
    }
}
