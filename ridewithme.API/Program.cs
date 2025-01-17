using Mapster;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.OpenApi.Models;
using ridewithme.API;
using ridewithme.API.Filters;
using ridewithme.Model.Requests;
using ridewithme.Service;
using ridewithme.Service.Database;
using ridewithme.Service.KuponiStateMachine;
using ridewithme.Service.VoznjeStateMachine;
using ridewithme.Service.ZalbeStateMachine;
using ridewithme.Services;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddTransient<IVoznjeService, VoznjeService>();
builder.Services.AddTransient<IKorisniciService, KorisniciService>();
builder.Services.AddTransient<IUlogeervice, Ulogeervice>();
builder.Services.AddTransient<IGradoviService, GradoviService>();
builder.Services.AddTransient<IKuponiService, KuponiService>();
builder.Services.AddTransient<IVrstaZalbeService, VrstaZalbeService>();
builder.Services.AddTransient<IZalbeService, ZalbeService>();
builder.Services.AddTransient<IReklameService, ReklameService>();
builder.Services.AddTransient<IEmailService, EmailService>();

//State machine
builder.Services.AddTransient<BaseVoznjeState>();
builder.Services.AddTransient<InitialVoznjeState>();
builder.Services.AddTransient<DraftVoznjeState>();
builder.Services.AddTransient<ActiveVoznjeState>();
builder.Services.AddTransient<HiddenVoznjeState>();
builder.Services.AddTransient<BookedVoznjeState>();

builder.Services.AddTransient<BaseKuponiState>();
builder.Services.AddTransient<InitialKuponiState>();
builder.Services.AddTransient<DraftKuponiState>();
builder.Services.AddTransient<HiddenKuponiState>();
builder.Services.AddTransient<ActiveKuponiState>();

builder.Services.AddTransient<BaseZalbeState>();
builder.Services.AddTransient<InitialZalbeState>();
builder.Services.AddTransient<ActiveZalbeState>();
builder.Services.AddTransient<ProcessingZalbeState>();
builder.Services.AddTransient<CompletedZalbeState>();


builder.Services.AddControllers(x=> x.Filters.Add<ExceptionFilter>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference{Type = ReferenceType.SecurityScheme, Id = "basicAuth"}
            },
            new string[]{}
    } });

});

var connectionString = builder.Configuration.GetConnectionString("ridewithme");
builder.Services.AddDbContext<RidewithmeContext>(options =>
    options.UseSqlServer(connectionString).EnableDetailedErrors().EnableSensitiveDataLogging());

builder.Services.AddMapster();
builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

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

using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<RidewithmeContext>();

    dataContext.Database.Migrate();
}

app.Run();
