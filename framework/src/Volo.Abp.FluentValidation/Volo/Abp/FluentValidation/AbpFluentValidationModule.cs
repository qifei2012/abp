using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;

namespace Volo.Abp.FluentValidation
{
    [DependsOn(AbpValidationModule)]
    public class AbpFluentValidationModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.OnRegistred(FluentValidationInterceptorRegistrar.RegisterIfNeeded);
        }
    }
}
