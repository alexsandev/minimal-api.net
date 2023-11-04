using MinimalAPI.Model.Resources;
using MinimalAPI.Model.Services;

namespace MinimalAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Habilitando o swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.MapGet("/", () => "API inicializada");

            try
            {
                UserResource resources = new UserResource(new UserService());

                app.MapGet("/users", resources.FindAll);

                app.MapGet("/users/{id}", resources.FindById);

                app.MapPost("/users/create", resources.Create);

                app.MapPut("/users/update", resources.Update);

                app.MapDelete("/users/delete/{id}", resources.DeleteById);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            app.UseSwagger();// Ativando o Swagger

            app.UseSwaggerUI();// Ativando a interface Swagger

            app.Run();
        }
    }
}