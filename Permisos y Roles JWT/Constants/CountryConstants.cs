using Permisos_y_Roles_JWT.Models;

namespace Permisos_y_Roles_JWT.Constants
{
    public class CountryConstants
    {
        public static List<CountryModel> Countries = new List<CountryModel>()
        {
            new CountryModel() { Name = "Bolivia" },
            new CountryModel() { Name = "Argentina" },
            new CountryModel() { Name = "Colombia" },
            new CountryModel() { Name = "Chile" }
        };
    }
}
