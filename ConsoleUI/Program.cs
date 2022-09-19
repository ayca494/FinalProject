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
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            //ProductManager productManager  = new ProductManager(new EfProductDal()); //Projeyi entitye çevirince sadece burası değiştirdik 
            //Business'a bana bütün ürünleri ver diyor item dediği her bir product 
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
