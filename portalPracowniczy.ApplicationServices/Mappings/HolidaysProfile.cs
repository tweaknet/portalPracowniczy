using AutoMapper;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess.Entities;

namespace portalPracowniczy.ApplicationServices.Mappings
{
    public class HolidaysProfile : Profile
    {
        public HolidaysProfile()
        {
            this.CreateMap<AddHolidayRequest, Holiday>()
                .ForMember(x => x.IdHolidayType, y => y.MapFrom(z => z.IdHolidayType))
                .ForMember(x => x.Data, y => y.MapFrom(z => z.Data))
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.IdUser, y => y.MapFrom(z => z.IdUser));

            this.CreateMap<Holiday, API.Domain.Models.Holiday>()
                .ForMember(x => x.IdHolidayType, y => y.MapFrom(z => z.IdHolidayType))
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

            this.CreateMap<DeleteHolidayRequest, Holiday>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

            this.CreateMap<PutHolidayRequest, Holiday>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.IdHolidayType, y => y.MapFrom(z => z.IdHolidayType))
                .ForMember(x => x.Data, y => y.MapFrom(z => z.Data))
                .ForMember(x => x.IdUser, y => y.MapFrom(z => z.IdUser));
        }
    }
}
