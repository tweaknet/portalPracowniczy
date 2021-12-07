using AutoMapper;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess.Entities;

namespace portalPracowniczy.ApplicationServices.Mappings
{
    public class HolidayTypeProfile : Profile
    {
        public HolidayTypeProfile()
        {
            this.CreateMap<AddHolidayTypeRequest, HolidayType>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.IdRCP, y => y.MapFrom(z => z.IdRCP))
                //.ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.IdERP, y => y.MapFrom(z => z.IdERP));

            this.CreateMap<HolidayType, API.Domain.Models.HolidayType>()
                //.ForMember(x => x.IdHolidayType, y => y.MapFrom(z => z.IdHolidayType))
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

            this.CreateMap<DeleteHolidayTypeByIdRequest, HolidayType>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

            this.CreateMap<PutHolidayTypeRequest, HolidayType>()
                //.ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.IdRCP, y => y.MapFrom(z => z.IdRCP))
                .ForMember(x => x.IdERP, y => y.MapFrom(z => z.IdERP));
        }
    }
}
