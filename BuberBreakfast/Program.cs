using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
// the build variuable , we can use for dependency injection and configuration
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IBreakfastService, BreakfastService>();
var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
