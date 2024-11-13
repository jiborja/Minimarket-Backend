using Aplicacion;
using Persistencia;
using Asp.Versioning;
using Microsoft.AspNetCore.Identity;
using WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddPersistenceInfraestructure(configuration);
builder.Services.AddApplicationLayer();
builder.Services.AddApiVersioning();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// using(var scope = app.Services.CreateScope())
// {
//     var services = scope.ServiceProvider;
//     try{
//         var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
//         var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

//         await DefaultRoles.SeedAsync(userManager,roleManager);
//         await DefaultUsers.SeedAsync(userManager);
//     }
//     catch(Exception ex)
//     {
//         throw;
//     }
// }

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseErrorHandleingMiddleware();

app.MapControllers();

app.Run();