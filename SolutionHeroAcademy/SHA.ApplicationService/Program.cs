var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: "_CORS_DEVELOPEMENT_POLICY", policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

// Global application settings, used in the development and production environment.

app.UseAuthorization();

app.MapControllers();

if (app.Environment.IsDevelopment()) // Application settings used in the development environment.
{
    app.UseDeveloperExceptionPage();
    app.UseCors("_CORS_DEVELOPEMENT_POLICY");
}
else // Application settings used in the development environment.'
{
    app.UseHttpsRedirection();
}

app.Run();