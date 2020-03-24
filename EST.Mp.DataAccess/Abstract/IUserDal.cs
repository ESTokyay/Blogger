using EST.Mp.Core.DataAccess;
using EST.Mp.Entities.Concrete;

namespace EST.Mp.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<Users>
    {
       // User ile ilgili özel operasyonlar buraya yazılacak.
    }
}
