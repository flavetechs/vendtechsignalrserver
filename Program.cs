using Microsoft.EntityFrameworkCore;
using signalrserver.Hub_connection;
using signalrserver.Models.Context;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
        builder.WithOrigins("https://vendtechsl.com", "http://localhost:56549", "http://vendtechsl.net", "https://www.vendtechsl.com:459")//
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials()
               .SetIsOriginAllowed((builer) => true));
});

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSignalR();

var app = builder.Build();

app.UseCors("CORSPolicy");

app.MapHub<MessageHub>("/messages").RequireCors("CORSPolicy");
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
