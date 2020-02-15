using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MsHostBuilderApp
{
    public class MyHostBuilder
    {
        public static HostBuilder CreateHostBuilder()
        {

            var hostBuilder = new HostBuilder();

            hostBuilder.ConfigureServices((ctx, serviceCollection) =>
            {
                var enemy = new Enemy()
                {
                    Name = "Mr Badguy"
                };
                serviceCollection.AddSingleton<Enemy>(enemy);
                serviceCollection.AddScoped<Hero>();

                serviceCollection.AddTransient<IWeapon, Sword>();
                serviceCollection.AddTransient<Game>();
            });



            return hostBuilder;

        }
    }
}
