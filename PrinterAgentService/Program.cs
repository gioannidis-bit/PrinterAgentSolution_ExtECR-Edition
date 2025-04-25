using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PrinterAgent.Core.Data;
using System;
using PrinterAgent.Core.Services;
using PrinterAgentService.Services;

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
                // ���������� ����� �� ������ appsettings.json
                .ConfigureAppConfiguration((ctx, cfg) =>
                {
                    cfg.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                    // ����������� ���������� ��� appsettings.{Environment}.json 
                    cfg.AddJsonFile(
                        $"appsettings.{ctx.HostingEnvironment.EnvironmentName}.json",
                        optional: true,
                        reloadOnChange: true);
                    cfg.AddEnvironmentVariables();
                })
                .UseWindowsService() // Uncomment �� ������ deploy �� Windows Service
                .ConfigureServices((hostContext, services) =>
                {
                    // ������� �Test� � �Default� ���� ��� �������� "Environment"
                    var envKey = hostContext.Configuration["Environment"] ?? "Default";
                    var connString = envKey == "Test"
                        ? hostContext.Configuration.GetConnectionString("TestConnection")
                        : hostContext.Configuration.GetConnectionString("DefaultConnection");

                    // ���������� ��� DbContext �� SQL Server
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer(connString));

                    services.AddScoped<ITemplateService, TemplateService>();


                    services.AddSingleton<Worker>();
                    services.AddHostedService(sp => sp.GetRequiredService<Worker>());
                });
    }
}
