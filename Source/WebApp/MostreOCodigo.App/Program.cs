using Microsoft.EntityFrameworkCore;
using MostreOCodigo.CrossCutting;
using MostreOCodigo.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddServices();

builder.Services.AddDbContext<SkynetzContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBMostreOCodigo")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Valor}/{action=Index}");

app.Run();
