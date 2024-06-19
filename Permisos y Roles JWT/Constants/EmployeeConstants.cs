using Permisos_y_Roles_JWT.Models;

namespace Permisos_y_Roles_JWT.Constants
{
    public class EmployeeConstants
    {
        public static List<EmployeeModel> Employees = new List<EmployeeModel>()
        {
            new EmployeeModel(){ Firstname = "Lucas", Lastname = "Quiriga", Email = "lquiroga@mail.com" },
            new EmployeeModel(){ Firstname = "Andres", Lastname = "Martinez", Email = "amartinez@mail.com" },
            new EmployeeModel(){ Firstname = "Noel", Lastname = "Perez", Email = "nperez@mail.com" }
        };
    }
}
