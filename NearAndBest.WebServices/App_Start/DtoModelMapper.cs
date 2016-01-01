namespace NearAndBest.WebServices
{
    using AutoMapper;
    using NearAndBest.DTOs.Admin;
    using NearAndBest.Models.Admin;

    public class DtoModelMapper : Profile
    {
        protected override void Configure()
        {
            base.Configure();

            Mapper.CreateMap<RoleDTO, RoleModel>().ReverseMap();
        }
    }
}