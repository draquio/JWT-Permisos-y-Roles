using Permisos_y_Roles_JWT.Models;

namespace Permisos_y_Roles_JWT.Constants
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel()
            {
                Username = "draquio",
                Password = "123",
                Rol = "Administrador",
                Email = "draquio@mail.com",
                Firstname = "Andres",
                Lastname = "Garcia"
            },
            new UserModel()
            {
                Username = "mlopez",
                Password = "321",
                Rol = "Vendedor",
                Email = "mlopez@mail.com",
                Firstname = "Martin",
                Lastname = "Lopez"
            }
        };
    }
}
