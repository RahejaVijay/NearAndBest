namespace NearAndBest.Facade.UnitTest
{
    using AutoMapper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Configuration
    {
        internal static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new EntityDtoMapper());
            });
        }
    }
}
