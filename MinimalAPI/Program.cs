using Dapper.Contrib.Extensions;

namespace MinimalAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connection = Database.GetConnection();

            var builder = WebApplication.CreateBuilder(args);

            //Habilitando o swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.MapGet("/", () => "API inicializada");

            app.MapGet("/users", () => {
                return connection.GetAll<User>().ToList();
            });

            app.MapGet("/users/{id}", (int id) => {
                return connection.Get<User>(id);
            });

            app.MapPost("/users/create", (User user) => {
                connection.Insert(user);
            });

            app.MapPut("/users/update/{id}", (int id, User obj) => {
                User user = connection.Get<User>(id);
                if(user != null)
                {
                    user.Name = obj.Name;
                    user.Email = obj.Email;
                    user.Password = obj.Password;
                    connection.Update(user);
                }
            });

            app.MapDelete("/users/delete/{id}", (int id) => {
                connection.Delete(new User(id, null, null, null));
            });

            app.UseSwagger();// Ativando o Swagger

            app.UseSwaggerUI();// Ativando a interface Swagger

            app.Run();
        }
    }
}