// See https://aka.ms/new-console-template for more information
using Reductio___Absurdum;

Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class Program
{
    private static List<Product> products = new List<Product>();
    private static List<ProductType> productTypes = new List<ProductType>
    {
        new ProductType { Id = 1, Name = "Apparel" },
        new ProductType { Id = 2, Name = "Potions" },
        new ProductType { Id = 3, Name = "Enchanted Objects" },
        new ProductType { Id = 4, Name = "Wands" }
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. View all products");
            Console.WriteLine("2. Add a product to the inventory");
            Console.WriteLine("3. Delete a product from the inventory");
            Console.WriteLine("4. Update a product's details");
            Console.WriteLine("5. Red's product lookup by product type");
            Console.WriteLine("6. Abe's product lookup by product type");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        ViewAllProducts();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        UpdateProduct();
                        break;
                    case 5:
                        RedProductLookup();
                        break;
                    case 6:
                        AbeProductLookup();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine();
        }
    }