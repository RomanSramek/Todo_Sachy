using Todo;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/Bp1", () =>
{
    
});

app.MapPost("/{pohyb}", (string pohyb) =>
{
    if (!Pohyb.TryParse(pohyb, out IPohyb _pohyb))
        throw new Exception("Neznamy pohyb");


});

app.Run();






