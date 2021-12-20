using AutoMapper;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess.Entities;

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
                .ForMember(x => x.Login, y => y.MapFrom(z => z.Login))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));

            this.CreateMap<ValidateUserRequest, API.Domain.Models.User>()
                .ForMember(x => x.Login, y => y.MapFrom(z => z.Login));
                //.ForMember(x => x.Password, y => y.MapFrom(z => z.Password));

            this.CreateMap<DeleteUserRequest, User>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.UserId));

            this.CreateMap<PutUserRequest, User>()
                .ForMember(x => x.Login, y => y.MapFrom(z => z.Login))
                .ForMember(x => x.Password, y => y.MapFrom(z => z.Password))
                .ForMember(x => x.IdBranch, y => y.MapFrom(z => z.IdBranch))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
        }
    }
}