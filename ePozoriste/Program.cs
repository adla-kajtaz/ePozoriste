using ePozoriste.Services.Database;
using ePozoriste.Services;
using ePozoriste.Services.Mapping;
using Microsoft.EntityFrameworkCore;
using ePozoriste;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(x =>
{
    x.Filters.Add<ErrorFilter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ePozoristeContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<IDrzavaService, DrzavaService>();
builder.Services.AddTransient<IGradService, GradService>();
builder.Services.AddTransient<IUlogaService, UlogaService>();
builder.Services.AddTransient<IObavijestKategorijaService, ObavijestKategorijaService>();
builder.Services.AddTransient<IObavijestService, ObavijestService>();
builder.Services.AddTransient<IPozoristeService, PozoristeService>();
builder.Services.AddTransient<ISalaService, SalaService>();
builder.Services.AddTransient<IVrstaPredstaveService, VrstaPredstaveService>();
builder.Services.AddTransient<IGlumacService, GlumacService>();
builder.Services.AddTransient<IPredstavaService, PredstavaService>();
builder.Services.AddTransient<ITerminService, TerminService>();
builder.Services.AddTransient<IPredstavaGlumacService, PredstavaGlumacService>();
builder.Services.AddTransient<IKartaService, KartaService>();
builder.Services.AddTransient<IKupovinaService, KupovinaService>();
builder.Services.AddTransient<IKorisnikService, KorisnikService>();
builder.Services.AddTransient<IKorisnikUlogeService, KorisnikUlogeService>();
builder.Services.AddTransient<StripeService>();
builder.Services.AddTransient<PayPalService>();



builder.Services.AddAutoMapper(typeof(Program), typeof(MapperProfiles));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using(var scope = app.Services.CreateScope())
{
    string? connection = app.Configuration.GetConnectionString("DefaultConnection");
    var dataContext = scope.ServiceProvider.GetRequiredService<ePozoristeContext>();
    dataContext.Database.Migrate();
}

app.Run();

