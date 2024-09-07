using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop_2.ProductTypes
{
    /// <summary>
    /// This class contains all available attributes for products added.
    /// </summary>
    public class Product
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; } = "";
        public string Material { get; set; } = "";
        protected int ProductID { get; set; }
        public Product()
        {

        }

    }
}
