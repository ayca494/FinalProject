using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları Veri iş kodlarından geçiyorsa veri erişimi çağırmam gerek 
            //Bir iş sınıfı başka sınıfları new'lemez yani nesne oluşturmaz onun yerine constructor yapmalıyız  
            // InMemory ve Entity kısmı burada geçmeyecek
            // yetkisi var mı? okeyse burdan return diyerek verileri alabiliyor yoksa kontrol ettiğimiz şeye göre geliyor
            
            return _productDal.GetAll();
        }
    }
}
