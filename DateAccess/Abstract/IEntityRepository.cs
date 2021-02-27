using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Abstract
{
    //generic constraint
    //burada class demek referans tip olabilir demek
    //burada IEntity eklemek IEntity olabilir veya bunu implemente eden bir nesne olabilir.
    //burada new() demek newlenebilir olmalı demek.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
