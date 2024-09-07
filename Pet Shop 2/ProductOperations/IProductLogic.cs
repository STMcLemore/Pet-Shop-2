using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Shop_2.ProductTypes;

namespace Pet_Shop_2.ProductOperations
{
    internal interface IProductLogic
    {
        public void AddProduct(Product product);

        public List<Product> GetAllProducts();

        public DogLeash GetDogLeashesByName(string name);

        public List<string> GetOnlyInStockProducts();

        public List<string> GetOutOfStockProducts();

    }
}
