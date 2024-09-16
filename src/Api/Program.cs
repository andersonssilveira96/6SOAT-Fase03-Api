using Api.Extensions;
using Application;
using Infra.Data;
using Infra.Gateway;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationService();
builder.Services.AddInfraDataServices();
builder.Services.AddInfraGatewayServices();

builder.Services.AddDbContext<TechChallengeContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("Database")));

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.ApplyMigrations();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
