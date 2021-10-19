using Microsoft.Extensions.DependencyInjection;
using WebApi.Features.Locations.Services;

namespace WebApi.Features.Locations
{
    public class Injector: InjectorBase
    {
        public override void Inject(IServiceCollection services)
        {
            services.AddScoped<ILocationsService, LocationsService>();
        }
    }
}