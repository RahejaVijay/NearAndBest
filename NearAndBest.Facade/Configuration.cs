namespace NearAndBest.Facade
{
    using AutoMapper;

    public  class Configuration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new EntityDtoMapper());
            });
        }
    }
}
