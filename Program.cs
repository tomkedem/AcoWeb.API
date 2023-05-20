using AcoWeb.API.DbContexts;
using AcoWeb.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

AddServices(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

ReCreateDatabase(app);

app.Run();

void AddServices(WebApplicationBuilder builder)
{
    builder.Services.AddControllers();

    builder.Services.AddDbContext<EmployeesContext>(options =>
    {
        options.UseSqlServer(
            @"Server=DESKTOP-OOQ5RCV\SQLEXPRESS;Database=EmployeesAcoDb1;TrustServerCertificate=true;Trusted_Connection=true;");

        options.LogTo(Console.WriteLine);
        options.EnableSensitiveDataLogging(true);
    });

    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    builder.Services.AddScoped<IEmployeesRepository, EmployeesRepository>();

}

void ReCreateDatabase(WebApplication app)
{

    using (var scop = app.Services.CreateScope())
    {
        try
        {
            var context = scop.ServiceProvider.GetService<EmployeesContext>();
            context.Database.EnsureDeleted();
            context.Database.Migrate();
        }
        catch (Exception ex)
        {

            var logger = scop.ServiceProvider.GetRequiredService<ILogger>();
            logger.LogError(ex, "Error happens when migrating the database.");
        }
    }

}