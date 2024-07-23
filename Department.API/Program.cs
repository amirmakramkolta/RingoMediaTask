using Department.API.Extentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.RegisterServices(typeof(Program));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.RegisterPipelineComponents(typeof(Program));


app.Run();
