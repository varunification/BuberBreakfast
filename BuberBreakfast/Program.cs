using AutoMapper;
using BuberBreakfast.Mapping;
using BuberBreakfast.Services.Breakfasts;
IMapper mapper = AutoMapperConfiguration.Configure();
var builder = WebApplication.CreateBuilder(args);
// the build variuable , we can use for dependency injection and configuration
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IBreakfastService, BreakfastService>();
builder.Services.AddSingleton(mapper); // Register the IMapper instance
var app = builder.Build();
app.UseExceptionHandler("/error");
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
