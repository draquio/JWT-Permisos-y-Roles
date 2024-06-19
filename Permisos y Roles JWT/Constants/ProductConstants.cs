using Permisos_y_Roles_JWT.Models;

namespace Permisos_y_Roles_JWT.Constants
{
    public class ProductConstants
    {
        public static List<ProductModel> Products = new List<ProductModel>()
        {
            new ProductModel(){ Name = "Huawei p30", Description = "celulcar marca huawei" },
            new ProductModel(){ Name = "TV Smart LG", Description = "Telvisor LG" },
            new ProductModel(){ Name = "TV Master G", Description = "Telvisor Master G" }
        };
    }
}
