using API.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EfCore6DbTest;Trusted_Connection=True;MultipleActiveResultSets=true");
});

builder.Services.AddTransient<DataSeeder>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await context.Database.MigrateAsync();
}

var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

using (var scope = scopedFactory.CreateScope())
{
    var service = scope.ServiceProvider.GetService<DataSeeder>();
    await service.Seed();
}

app.UseHttpsRedirection();

app.MapGet("/users", async (AppDbContext context) =>
{
    var data = await context.Users.Include(c => c.Addresses).ToListAsync();

    return data;
});

app.Run();