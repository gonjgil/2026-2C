using GJG.Logica;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IEscuderiasServicio, EscuderiasServicio>();
builder.Services.AddSingleton<IPilotosServicio, PilotosServicio>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "piloto",
    pattern: "Pilotos/NuevoPiloto/{escuderiaId?}",
    defaults: new { controller = "Pilotos", action = "NuevoPiloto" });
    
app.MapControllerRoute(name: "default", pattern: "{controller=Escuderias}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
