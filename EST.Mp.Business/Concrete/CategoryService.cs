using EST.Mp.Business.Abstract;
using EST.Mp.DataAccess.Abstract;
using EST.Mp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EST.Mp.Business.Concrete.EntityFramework
{
    public class CategoryService : ICategoryServices
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Categories entity)
        {
            _categoryDal.Add(entity);
        }

        public void Delete(Categories entity)
        {
            _categoryDal.Delete(entity);
        }

        public Categories Get(Expression<Func<Categories, bool>> filter = null)
        {
            return _categoryDal.Get(filter);
        }

        public List<Categories> GetList(Expression<Func<Categories, bool>> filter = null)
        {
            return _categoryDal.GetList(filter);
        }

        public void Update(Categories entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
