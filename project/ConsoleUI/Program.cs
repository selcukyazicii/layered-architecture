using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //hangi veri yöntemiyle çalıştığını bana söyle
            //işçi kodlar DAL'da olduğu için onu newleriz


            //OrderTest();
            ProductTest();
            //CategoryTest();

        }

        private static void OrderTest()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var item in orderManager.GetAll())
            {
                Console.WriteLine(item.ShipCity);
            }
        }
       

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll().Data)
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            //veri true'sa foreach ile döndür, değilse message yazdır
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName+ " " + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

    }
}
