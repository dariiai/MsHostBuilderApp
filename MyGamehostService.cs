using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace MsHostBuilderApp
{
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
