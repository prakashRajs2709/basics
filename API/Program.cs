using API;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);
var app = builder.Build();

app.UseCors("AllowAngularDevClient");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
