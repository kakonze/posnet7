using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Posnet7.Data;
using RazorPagesMovie.Data;
using posnet7.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<SaleDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SaleDbContext") ?? throw new InvalidOperationException("Connection string 'SaleDbContext' not found.")));
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductDbContext") ?? throw new InvalidOperationException("Connection string 'ProductDbContext' not found.")));
builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesMovieContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesMovieContext' not found.")));

//Enable runtime compilation
builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();
var app = builder.Build();

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

//app.UseAuthorization();

app.MapRazorPages();

app.Run();
