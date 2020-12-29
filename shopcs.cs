using System;
using System.Collections;
using System.Collections.Generic;

namespace Manage_Products
{
    public class shopcs
    {
        
        public ArrayList ProductList = new ArrayList();

        public void Add(Product item)
        {         
            ProductList.Add(item);
        }
        public void Remove(string name)
        {
            foreach (Product item in ProductList)
            {
                if(item.Name == name)
                {
                    ProductList.Remove(item);
                    Console.WriteLine("xoa thanh cong");
                    break;
                }
                else
                {
                    Console.WriteLine("khong co san pham nay");
                }
            }
            
        }

        public void Iterate()
        {
            foreach (Product item in ProductList)
            {
                //item.CalculatorRate();
                Console.Write(item.Viewinfo());
                Console.WriteLine();
            }
        }

        public void Search(int min, int max)
        {
            foreach (Product item in ProductList)
            {
                if(item.Price > min && item.Price < max)
                {
                      Console.WriteLine(item.Viewinfo());
                }
                else
                {
                    Console.Write("khong tim thay san pham");
                    break;
                }    
              
            }
        }

        public void RateProduct(string nameProduct,int rate)
        {

            foreach (Product item in ProductList)
            {
                if (item.Name == nameProduct)
                {
                    item.Rate.Add(rate);
                    break;
                }
                else
                {
                    Console.WriteLine("khong co san pham nay");
                }
            }


        }
    }
}