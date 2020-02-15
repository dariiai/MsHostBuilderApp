using System.Threading;
using System.Threading.Tasks;
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

                serviceCollection.AddHostedService<MyGamehostService>();
            });

            return hostBuilder;
        }
    }

    public class MyGamehostService : IHostedService
    {
        public MyGamehostService(Game game)
        {
            Game = game;
        }

        public Game Game { get; }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await Game.Start();
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }
    }
}
