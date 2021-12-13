using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Storage
    {
        public static List<ProductModel> Products { get; set; } = new List<ProductModel>()
        {
            new ProductModel()
            {
                Id = 1,
                Description = "Belarusian",
                Name = "Potato",
                Price = "5 USD"
            },
                new ProductModel()
            {
                Id = 2,
                Description = "Ukranian, very cool",
                Name = "Salo",
                Price = "25 USD"
            },
                new ProductModel()
            {
                Id = 3,
                Description = "Special russian",
                Name = "Kvas",
                Price = "2 USD"
            }
        };
    }
}
