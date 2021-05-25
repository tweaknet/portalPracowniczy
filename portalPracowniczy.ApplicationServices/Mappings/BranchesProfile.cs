using AutoMapper;
using portalPracowniczy.ApplicationServices.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.Mappings
{
    public class BranchesProfile : Profile
    {
        public BranchesProfile()
        {
            this.CreateMap<portalPracowniczy.DataAccess.Entities.Branch, Branch>()
        .ForMember(x => x.IdSuperior, y => y.MapFrom(z => z.IdSuperior))
        .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
        }
    }
}
