using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //O open closed principle
    //IoC
    //Dto Data Transformation Object
    public class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            //foreach (var product in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //Console.WriteLine("*-*-*-*-*-*-*-*");
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //Console.WriteLine("*-*-*-*-*-*-*-*");
            //foreach (var product in productManager.GetByUnitPrice(40, 100))
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //Console.WriteLine("*-*-*-*-*-*-*-*");

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data )
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

    }
}
