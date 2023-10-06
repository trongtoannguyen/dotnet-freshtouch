using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

if (builder.Environment.IsDevelopment())
{
    var conStrBuilder = new SqlConnectionStringBuilder(
            builder.Configuration.GetConnectionString("RazorPagesMovieContext"));
    if (conStrBuilder != null)
    {
        conStrBuilder.Password = builder.Configuration["DbPassword"];
        var connectionString = conStrBuilder.ConnectionString;
        builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
            options.UseSqlServer(connectionString));
    }
    else
    {
        throw new InvalidOperationException("Connection string 'ProductionMovieContext' not found.");
    }
    // builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
    //     options.UseSqlServer(connectionString));
}
else
{
    builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionMovieContext") ?? throw new InvalidOperationException("Connection string 'ProductionMovieContext' not found.")));
}

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();

app.Run();
