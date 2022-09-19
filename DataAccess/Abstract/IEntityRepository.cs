using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        //Getall dediğimde tamamı getirsin ama filterleme de yapalım aynı imzada
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Filtre boş da olabilir

        T Get(Expression<Func<T, bool>> filter); //filtre boş olamaz
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        ////Ürünleri kategoriye göre filtrele
        //List<T> GetAllByCategory(int categoryId);
    }
}
