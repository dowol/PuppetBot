using PuppetBot.Server.Utilities;
using PuppetBot.Data.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSignalR()
    .AddJsonProtocol(opt => opt.PayloadSerializerOptions.Initialize());

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}
else
{
    builder.WebHost.ListenFromPort(builder.Configuration.GetSection("Server:Port").Get<int?>() ?? 65001);
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.MapSignalRHubs();

app.Run();
