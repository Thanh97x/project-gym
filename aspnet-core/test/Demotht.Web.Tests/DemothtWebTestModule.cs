using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Demotht.EntityFrameworkCore;
using Demotht.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Demotht.Web.Tests
{
    [DependsOn(
        typeof(DemothtWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DemothtWebTestModule : AbpModule
    {
        public DemothtWebTestModule(DemothtEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemothtWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DemothtWebMvcModule).Assembly);
        }
    }
}