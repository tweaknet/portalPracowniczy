using AutoMapper;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess.Entities;

namespace portalPracowniczy.ApplicationServices.Mappings
{
    public class BranchesProfile : Profile
    {
        public BranchesProfile()
        {
            this.CreateMap<Branch, API.Domain.Models.Branch>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.IdSuperior, y => y.MapFrom(z => z.IdSuperior))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));

            this.CreateMap<AddBranchRequest,Branch>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, z => z.MapFrom(y => y.Name))
                .ForMember(x => x.IdSuperior,y => y.MapFrom(z => z.IdSuperior));

            this.CreateMap<DeleteBranchByIdRequest, Branch>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

            this.CreateMap<PutBranchRequest, Branch>()
                //.ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.IdSuperior, y => y.MapFrom(z => z.IdSuperior))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
        }
    }
}
