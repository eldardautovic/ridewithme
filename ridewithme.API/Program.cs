using Mapster;
using Microsoft.EntityFrameworkCore;
using ridewithme.Service;
using ridewithme.Service.Database;
using ridewithme.Service.VoznjeStateMachine;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IVoznjeService, VoznjeService>();
builder.Services.AddTransient<IKorisniciService, KorisniciService>();
builder.Services.AddTransient<IUlogeService, UlogeService>();

builder.Services.AddTransient<BaseVoznjeState>();
builder.Services.AddTransient<InitialVoznjeState>();
builder.Services.AddTransient<DraftVoznjeState>();
builder.Services.AddTransient<ActiveVoznjeState>();
builder.Services.AddTransient<HiddenVoznjeState>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("ridewithme");
builder.Services.AddDbContext<RidewithmeContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddMapster();

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

app.Run();
