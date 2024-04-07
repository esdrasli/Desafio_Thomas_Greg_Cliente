using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicione serviços ao contêiner
builder.Services.AddControllers();

// Adicione o contexto do banco de dados
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptionsAction => sqlServerOptionsAction.EnableRetryOnFailure()));



// Adicione o repositório de cliente e sua implementação ao contêiner
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

// Adicione o serviço de cliente e sua implementação ao contêiner
builder.Services.AddScoped<IClienteService, ClienteService>();

// Mais configurações de serviço, como Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure o pipeline de solicitação HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
