// See https://aka.ms/new-console-template for more information

using Pet_Shop_2;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Pet_Shop_2.ProductTypes;
using Pet_Shop_2.ProductOperations;
{
    var productLogic = new ProductLogic();
    var _products = new List<Product>();


    string userInput = "";


    while (userInput.ToLower() != "exit")
    {
        Console.WriteLine("Press 1 to ADD a dog leash product");
        Console.WriteLine("Press 2 to VIEW a dog leash product");
        Console.WriteLine("Press 3 to VIEW ALL items");
        Console.WriteLine("Press 4 to VIEW all items in stock");
        Console.WriteLine("Press 5 to see OUT OF STOCK items");
        Console.WriteLine("Type 'exit' to quit");

        userInput = Console.ReadLine();

        switch (userInput)
        {
                case "1":
                {
                    var dogLeash = new DogLeash();

                    Console.WriteLine("Enter Product Name");
                    dogLeash.Name = Console.ReadLine();


                    Console.WriteLine("Enter product Description");
                    dogLeash.Description = Console.ReadLine();

                    Console.WriteLine("Enter product Material");
                    dogLeash.Material = Console.ReadLine();

                    Console.WriteLine("Enter product Quantity");
                    dogLeash.Quantity = int.Parse(Console.ReadLine());
      

                    productLogic.AddProduct(dogLeash);
                    _products.Add(dogLeash);

                    Console.WriteLine("--------");
                    Console.WriteLine($"Product Name = {dogLeash.Name}, Description = {dogLeash.Description}, Material = {dogLeash.Material} Quantity = {dogLeash.Quantity}");
                    Console.WriteLine("--------");
                }
                break;
                


                case "2":
                {
                    Console.WriteLine("Enter the name of the dog leash product");
                    var name = Console.ReadLine();

                    var dogLeash = productLogic.GetDogLeashesByName(name);

                    if (productLogic.GetDogLeashesByName(name) == null)
                    {
                        Console.WriteLine("--------");
                        Console.WriteLine("No product found with that name");
                        Console.WriteLine("--------");
                    }

                    else
                    {
                        Console.WriteLine(name);
                        Console.WriteLine("--------");
                        Console.WriteLine($"Price = {dogLeash.Price}, Discounted Price = {dogLeash.Price.DiscountThisPrice()}");
                        Console.WriteLine("--------");
                    }
                }
                break;


                case "3":
                {
                    productLogic.GetAllProducts();
                    foreach (var product in _products)
                    {
                        Console.WriteLine("--------");
                        Console.WriteLine("Name= " + product.Name);
                        Console.WriteLine("--------");
                    }
                }
                break;


                case "4":
                {
                    var inStock = productLogic.GetOnlyInStockProducts();
                    foreach (var item in inStock)
                    {
                        Console.WriteLine("--------");
                        Console.WriteLine(item);
                        Console.WriteLine("--------");
                    }
                }
                break;


                case "5":
                {
                    var outOfStock = productLogic.GetOutOfStockProducts();
                    foreach (var item in outOfStock)
                    {
                        Console.WriteLine("--------");
                        Console.WriteLine(item);
                        Console.WriteLine("--------");
                    }
                }
                break;
        }
    }
}






    



