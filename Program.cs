using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentManagement.Data;

var serviceProvider = new ServiceCollection()
    .AddDbContext<StudentContext>(options =>
        options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StudentManagementDb;Trusted_Connection=True;"))
    .BuildServiceProvider();

using (var context = serviceProvider.GetRequiredService<StudentContext>())
{
    // Apply any pending migrations automatically on startup
    context.Database.Migrate();
}

Console.WriteLine("Database created/migrated successfully!");
