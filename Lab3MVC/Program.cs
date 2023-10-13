using Lab3MVC.Data;
using Lab3MVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped(typeof(IRepository<ParkingSpot>), typeof(ParkingSpotRepo));
builder.Services.AddScoped(typeof(IRepository<Reservation>), typeof(ReservationRepo));
builder.Services.AddScoped(typeof(IRepository<Pass>), typeof(PassRepo));
builder.Services.AddScoped(typeof(IRepository<Vehicle>), typeof(VehicleRepo));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
