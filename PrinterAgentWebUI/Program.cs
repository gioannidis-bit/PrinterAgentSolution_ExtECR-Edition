using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrinterAgent.Core.Data;
using PrinterAgent.Core.Services;
using PrinterAgent.WebUI.Hubs;
using Microsoft.EntityFrameworkCore;
using PrinterAgentService.Services;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllersWithViews()
    .AddJsonOptions(opts =>
    {
        // allow EF Core cycles (PrintTemplate→Sections→PrintTemplate…)
        opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        // (you probably already have this)
        opts.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

builder.Configuration
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
       .AddEnvironmentVariables();


// Add services to the container.
builder.Services.AddSignalR();
builder.Services.AddCors(opts => opts.AddDefaultPolicy(b =>
    b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
builder.Services.AddDbContext<AppDbContext>(opts =>
    opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddScoped<ITemplateService, TemplateService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapHub<PrintHub>("/printHub");
app.UseCors();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
      pattern: "{controller=Dashboard}/{action=Index}/{id?}");

// still map your API controllers too
app.MapControllers();


app.Map("/health", appBuilder => {
    appBuilder.Run(async context => {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("OK");
    });
});


app.Run();
