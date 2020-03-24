using EST.Mp.Business.Abstract;
using EST.Mp.DataAccess.Abstract;
using EST.Mp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EST.Mp.Business.Concrete.EntityFramework
{
    public class CommentService : ICommentServices
    {
        private readonly ICommentDal _commentDal;

        public CommentService(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void Add(Comments entity)
        {
            _commentDal.Add(entity);
        }

        public void Delete(Comments entity)
        {
            _commentDal.Delete(entity);
        }

        public Comments Get(Expression<Func<Comments, bool>> filter = null)
        {
            return _commentDal.Get(filter);
        }

        public List<Comments> GetList(Expression<Func<Comments, bool>> filter = null)
        {
            return _commentDal.GetList(filter);
        }

        public void Update(Comments entity)
        {
            _commentDal.Update(entity);
        }
    }
}
