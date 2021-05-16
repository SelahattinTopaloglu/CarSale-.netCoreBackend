using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint (kısıtlama)
    //class : referans tip
    //IEntity : Ientity olabilir veya ordan implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı ()
    public interface IEntityRepository<T> where T:class,IEntity , new()
    {
        //expression ürünleri istenilen filtreleme (linq) sorgusuyla getirmek için kullanılır..
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        //tek bir hesabın detayını görmek icin T get
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GetById(int carId);  yukarideki expression sayesinde yapıldıgı için yorum satırı oldu
    }
}
