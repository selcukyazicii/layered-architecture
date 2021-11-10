using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class: referans tip olabilir
    //IEntity: IEntity yada onu implement eden bir nesne olabilir.
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        //filtre vermeyebilirsin,filtre yoksa tüm datayı getir
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        //tek şeyin detayı, spesifik detay filtre şart
        T Get(Expression<Func<T,bool>>filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
