﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DateAccess.Abstract;
using Entities.Concrete;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
