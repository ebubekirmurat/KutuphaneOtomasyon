using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using kutuphaneRezervasyon.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<KutuphaneContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("kutuphaneRezervasyonContext") ?? throw new InvalidOperationException("Connection string 'kutuphaneRezervasyonContext' not found.")));

builder.Services.AddDefaultIdentity<Kullanici>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<KutuphaneContext>();

builder.Services.AddHttpClient();
// Add services to the container.
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

app.MapRazorPages();    

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
