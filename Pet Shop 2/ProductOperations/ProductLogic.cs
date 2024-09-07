using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Pet_Shop_2.ProductTypes;

namespace Pet_Shop_2.ProductOperations
{
    /// <summary>
    /// This class contains the methods used to interact with products.
    /// </summary>
    public class ProductLogic : IProductLogic
    {

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogLeashes = new Dictionary<string, DogLeash>();
            _catsFoods = new Dictionary<string, CatFood>();

            AddProduct(new DogLeash { Name = "Leather Leash", Price = 26.99m, Quantity = 5 });
            AddProduct(new DogLeash { Name = "Bedazzled Leash", Price = 15.69m, Quantity = 0 });
        }


        public Product product = new Product();
        public DogLeash dogleash = new DogLeash();


        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashes;
        private Dictionary<string, CatFood> _catsFoods;


        public void AddProduct(Product product)
        {

            if (product is DogLeash)
            {
                _dogLeashes.Add(product.Name, product as DogLeash);
            }

            if (product is CatFood)
            {
                _catsFoods.Add(product.Name, product as CatFood);
            }
            _products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashesByName(string name)
        {
            try
            {
                return _dogLeashes[name];
            }
            catch
            {
                return null;
            }
        }

        public List<string> GetOnlyInStockProducts()
        {
            List<string> inStockProductNames = new List<string>();
            foreach (Product product in _products)
            {
                if (product.Quantity > 0)
                {
                    inStockProductNames.Add(product.Name);
                }
            }
            return inStockProductNames;
        }

        public List<string> GetOutOfStockProducts()
        {
            return _products.Where(p => p.Quantity == 0).Select(p => p.Name).ToList();
        }
    }
}
