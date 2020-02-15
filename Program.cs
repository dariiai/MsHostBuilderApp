using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MsHostBuilderApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = MyHostBuilder.CreateHostBuilder();
            var host = builder.Build();

            //using(IServiceScope scope = host.Services.CreateScope()){

            //    //var enemy1 = scope.ServiceProvider.GetService<Enemy>();
            //    //var hero1 = scope.ServiceProvider.GetService<Hero>();

            //    //var enemy2 = scope.ServiceProvider.GetService<Enemy>();

            //    //var hero2 = scope.ServiceProvider.GetService<Hero>();

            //    // System.Console.WriteLine($" enemy1 {enemy1.ID}  enemy2 {enemy2.ID} ");
            //    // System.Console.WriteLine($" hero1 {hero1.ID}  hero2 {hero2.ID} ");

            //    var game = scope.ServiceProvider.GetService<Game>();
            //    game.Start();
            //}

            await host.StartAsync();
        }
    }
}
