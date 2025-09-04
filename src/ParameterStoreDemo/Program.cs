var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddSystemsManager("/SampleApp"); // here the magic happens

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/connection", (IConfiguration configuration) =>
{
    var connectionString = configuration.GetConnectionString("MyConnection");

    return connectionString;
});

app.UseAuthorization();

app.MapControllers();

app.Run();
