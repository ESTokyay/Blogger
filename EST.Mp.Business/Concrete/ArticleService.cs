using EST.Mp.Business.Abstract;
using EST.Mp.DataAccess.Abstract;
using EST.Mp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EST.Mp.Business.Concrete.EntityFramework
{
    public class ArticleService : IArticleServices
    {
        private readonly IArticleDal _articleDal;

        public ArticleService(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
        public void Add(Articles entity)
        {
            _articleDal.Add(entity);
        }

        public void Delete(Articles entity)
        {
            _articleDal.Delete(entity);
        }

        public Articles Get(Expression<Func<Articles, bool>> filter = null)
        {
            return _articleDal.Get(filter);
        }

        public List<Articles> GetList(Expression<Func<Articles, bool>> filter = null)
        {
            return _articleDal.GetList(filter);
        }

        public void Update(Articles entity)
        {
            _articleDal.Update(entity);
        }
    }
}
