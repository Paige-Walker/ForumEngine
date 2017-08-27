namespace Data.Model.Mappings
{
    using Data.Models;
    using Domain.User;


    using AutoMapper;

    public class UserMap : Profile
    {
        public void InitializeMaps()
        {
            this.ConfigureMaps(); 
        }

        private void ConfigureMaps()
        {
            this.CreateMap<User, UserModel>()
                .ForMember(model => model.Id, opt => opt.MapFrom(entity => entity.Id))
                .ForMember(model => model.Name, opt => opt.MapFrom(entity => entity.Name))
                .ForMember(model => model.Email, opt => opt.MapFrom(entity => entity.Email))
                .ForMember(model => model.Permissions, opt => opt.MapFrom(entity => entity.Permissions))
                .ReverseMap()
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}