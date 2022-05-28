using BE.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

builder.Services.AddCors(x =>
    x.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

builder.Services.AddHttpClient("Movies", x =>
{
    x.BaseAddress = new Uri("https://online-movie-database.p.rapidapi.com");
    x.DefaultRequestHeaders.Add("X-RapidAPI-Host", "online-movie-database.p.rapidapi.com");
    x.DefaultRequestHeaders.Add("X-RapidAPI-Key", "b904daa359mshc83a3e5d3898718p14290djsnc1f4e2cb304c");
});

var app = builder.Build();


// Configure the HTTP request pipeline.
app.UseCors();
app.UseGrpcWeb();
app.MapGrpcService<MovieService>().EnableGrpcWeb();

app.Run();