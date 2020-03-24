using EST.Mp.Business.Abstract;
using EST.Mp.DataAccess.Abstract;
using EST.Mp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EST.Mp.Business.Concrete.EntityFramework
{
    public class UserService : IUserServices
    {

        private readonly IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(Users entity)
        {
            _userDal.Add(entity);
        }

        public void Delete(Users entity)
        {
            _userDal.Delete(entity);
        }

        public Users Get(Expression<Func<Users, bool>> filter = null)
        {
            return _userDal.Get(filter);                         //buradan emin değilim.
        }

        public List<Users> GetList(Expression<Func<Users, bool>> filter = null)
        {
            return _userDal.GetList(filter);
        }

        public void Update(Users entity)
        {
            _userDal.Update(entity);
        }
    }
}
