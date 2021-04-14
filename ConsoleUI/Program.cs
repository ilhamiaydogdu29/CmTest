using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();


        }
        /*private static void CategoryTest(){
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll().Data)
            {
                Console.WriteLine(item.Name);
            }
        }
        private static void ProductTest(){
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var item in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(item.CategoryName + " / " + item.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }*/
    }
   
}