using Refit;
using RegisterationService;
using FluentValidation;
using FluentValidation.AspNetCore;
using RegisterationService.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<RegisterSoftwareRequestModel>();

builder.Services.AddRefitClient<ISignatureAPI>().ConfigureHttpClient(c => 
{
    // TODO : The value of the url should come from the configurations which should be stored in some sort of vault.
    c.BaseAddress = new Uri(builder.Configuration.GetValue<string>("https://localhost:7221"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

