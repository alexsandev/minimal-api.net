using MinimalAPI.Model.Dao.Exceptions;
using MinimalAPI.Model.Entities;
using MinimalAPI.Model.Services;
using MinimalAPI.Model.Services.Exceptions;

namespace MinimalAPI.Model.Resources
{
    public class UserResource
    {
        private UserService _service;
        public UserResource(UserService service) 
        { 
            _service = service;
        }

        public IResult Create(User user)
        {
            try
            {
                return Results.Ok(_service.Create(user));

            }
            catch (UserServiceException e)
            {
                return Results.Problem(e.Message);
            }
        }

        public IResult FindAll()
        {
            try
            {
                return Results.Ok(_service.FindAll());
            }
            catch (UserServiceException e)
            {
                return Results.Problem(e.Message);
            }
        }

        public IResult FindById(int id)
        {
            try
            {
                return Results.Ok(_service.FindById(id));
            }
            catch (UserServiceException e)
            {
                return Results.Problem(e.Message);
            }
        }

        public IResult Update(User user)
        {
            try
            {
                return Results.Ok(_service.Update(user));
            }
            catch (UserServiceException e)
            {
                return Results.Problem(e.Message);
            }
        }

        public IResult DeleteById(int id)
        {
            try
            {
                return Results.Ok(_service.DeleteById(id));
            }
            catch (UserServiceException e)
            {
                return Results.Problem(e.Message);
            }
        }
    }
}
