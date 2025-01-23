using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using SmartTestTaskKozitski.DAL.Data;
using SmartTestTaskKozitski.MigrationTool;

Console.WriteLine("Applying migrations");

var webHost = new WebHostBuilder()
    .UseContentRoot(Directory.GetCurrentDirectory())
    .UseStartup<ConsoleStartup>()
    .Build();

using var context = (ApplicationContext)webHost.Services.GetService(typeof(ApplicationContext));
context.Database.Migrate();

Console.WriteLine("Done");