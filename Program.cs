using MinimalAPI.CodeSeparation;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// Static methods in seprate class files
app.MapWeatherForecast();
// using partial class
UserEndpoints.MapUserEndPoints(app);
// using interface
app.MapEndpoint();
var routes = app.MapGroup("minimalapis");
routes.MapTodosApi();
app.Run();


