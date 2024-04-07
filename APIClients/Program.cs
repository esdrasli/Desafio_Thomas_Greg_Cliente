using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicione servi�os ao cont�iner
builder.Services.AddControllers();

// Adicione o contexto do banco de dados
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptionsAction => sqlServerOptionsAction.EnableRetryOnFailure()));



// Adicione o reposit�rio de cliente e sua implementa��o ao cont�iner
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

// Adicione o servi�o de cliente e sua implementa��o ao cont�iner
builder.Services.AddScoped<IClienteService, ClienteService>();

// Mais configura��es de servi�o, como Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure o pipeline de solicita��o HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
