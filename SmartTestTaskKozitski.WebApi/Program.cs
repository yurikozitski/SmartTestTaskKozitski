using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartTestTaskKozitski.BLL.Extensions;
using SmartTestTaskKozitski.BLL.Mapping;
using SmartTestTaskKozitski.DAL.Data;
using SmartTestTaskKozitski.WebApi.Middleware;
using SmartTestTaskKozitski.WebApi.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutomapperProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddSecurity();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.OperationFilter<CustomHeaderParameter>());

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseMiddleware<ApiKeyMiddleware>();
app.UseMiddleware<ErrorHandlingMiddleware>();

app.MapControllers();
app.Run();
