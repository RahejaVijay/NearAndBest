using AutoMapper;
using NearAndBest.Facade;

namespace NearAndBest.WebServices
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new DtoModelMapper());
                cfg.AddProfile(new EntityDtoMapper());
            });
        }
    }
}