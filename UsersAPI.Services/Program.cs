using UsersAPI.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);//colocar a rota para minusculo
//builder.Services.AddEndpointsApiExplorer(); RETIRADO POQUE EU CRIEI UMA CLASSE  PARA ISSO
//builder.Services.AddSwaggerGen();RETIRADO POQUE EU CRIEI UMA CLASSE PARA ISSO
builder.Services.AddSwaggerDoc();

var app = builder.Build();

//if (app.Environment.IsDevelopment()) restringe rodar em produção
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseSwaggerDoc();// roda o Swagger tanto em produção quanto em dev
app.UseAuthorization();

app.MapControllers();

app.Run();
