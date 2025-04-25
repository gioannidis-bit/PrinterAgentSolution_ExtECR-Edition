using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PrinterAgent.Core.Data;
using System;

namespace PrinterAgentService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                // Φορτώνουμε πρώτα το βασικό appsettings.json
                .ConfigureAppConfiguration((ctx, cfg) =>
                {
                    cfg.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                    // Προαιρετικά φορτώνουμε και appsettings.{Environment}.json 
                    cfg.AddJsonFile(
                        $"appsettings.{ctx.HostingEnvironment.EnvironmentName}.json",
                        optional: true,
                        reloadOnChange: true);
                    cfg.AddEnvironmentVariables();
                })
                .UseWindowsService() // Uncomment αν θέλεις deploy ως Windows Service
                .ConfigureServices((hostContext, services) =>
                {
                    // Επιλογή “Test” ή “Default” βάση του κλειδιού "Environment"
                    var envKey = hostContext.Configuration["Environment"] ?? "Default";
                    var connString = envKey == "Test"
                        ? hostContext.Configuration.GetConnectionString("TestConnection")
                        : hostContext.Configuration.GetConnectionString("DefaultConnection");

                    // Καταχώρηση του DbContext με SQL Server
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer(connString));

                    // Η υπάρχουσα Hosted Service
                    services.AddHostedService<Worker>();
                });
    }
}
