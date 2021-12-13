using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class ProductModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Price")]
        public string Price { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }
    }
}
