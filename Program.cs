using System;
using System.Collections;
using System.Collections.Generic;

namespace Manage_Products
{
    class Program
    {
        static shopcs productList = new shopcs();
        static bool checkinput = false;
        static void Main(string[] args)
        {
            int choice;
            
            do
            {
                Console.WriteLine();
                Menu();
                Console.Write("moi nhap lua chon: ");
                checkinput = Int32.TryParse(Console.ReadLine(), out choice);
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        RemoveProduct();
                        break;
                    case 3:
                        IterateProduct();
                        break;
                    case 4:
                        Search();
                        break;
                    case 5:
                        Rate();
                        break;

                }

            } while (!checkinput || choice != 5);
            

        }


        static void Menu()
        {
            Console.WriteLine("PRODUCT MANAGEMENT SYSTEM!!!");
            Console.WriteLine("1.Add a product");
            Console.WriteLine("2.Remove Product");
            Console.WriteLine("3.Iterate product list");
            Console.WriteLine("4.Search product");
            Console.WriteLine("5.vote product");
            Console.WriteLine("6.Exit");
        }

        static void Add()
        {
            
            Product product = new Product();
            Console.Write("name product: ");
            product.Name = Console.ReadLine();
            Console.Write("depcription product: ");
            product.Description = Console.ReadLine();
            Console.Write("Price of product: ");         
            product.Price = double.Parse(Console.ReadLine()); 
            productList.Add(product);
            Console.WriteLine();
        }

        static void RemoveProduct()
        {
            Console.Write("nhap ten san pham can remove: ");
            string name2 = Console.ReadLine();
            productList.Remove(name2);
            Console.WriteLine();
        }
        static void IterateProduct()
        {
            productList.Iterate();
            Console.WriteLine();
        }

        static void Search()
        {
            Console.Write("nhap gia min: ");
            int min = Int32.Parse(Console.ReadLine());
            Console.Write("nhap gia max: ");
            int max = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            productList.Search(min, max);
            Console.WriteLine();
        }

        static void Rate()
        {
            Console.Write("nhap ten product can tim kiem!: ");
            string nameProduct = Console.ReadLine();
            Console.Write("nhap rate: ");
            int rate = Int32.Parse(Console.ReadLine());
            productList.RateProduct(nameProduct, rate);
        }




    }
}
