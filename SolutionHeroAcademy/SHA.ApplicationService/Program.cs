var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

// Global application settings, used in the development and production environment.

app.UseAuthorization();

app.MapControllers();

if (app.Environment.IsDevelopment()) // Application settings used in the development environment.
{
    app.UseDeveloperExceptionPage();
}
else // Application settings used in the development environment.'
{
    app.UseHttpsRedirection();
}

app.Run();