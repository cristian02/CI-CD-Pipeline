var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
};

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

//GET UTC
app.MapGet("time/out", () => Results.Ok(DateTime.UtcNow));

//
app.MapGet("time/lastTime", ()=> Results.Ok(DateTimeOffset.Now.AddDays(-1)));

app.Run();
