namespace NearAndBest.Facade
{
    using AutoMapper;
    using DTOs.Admin;
    using Entities.Admin;

    public class EntityDtoMapper : Profile
    {        
        protected override void Configure()
        {
            base.Configure();

            AutoMapper.Mapper.CreateMap<Role, RoleDTO>().ReverseMap();
        }
    }
}
