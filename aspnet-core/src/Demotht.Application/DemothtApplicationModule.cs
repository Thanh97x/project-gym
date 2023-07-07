using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Demotht.Authorization;

namespace Demotht
{
    [DependsOn(
        typeof(DemothtCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DemothtApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DemothtAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DemothtApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
