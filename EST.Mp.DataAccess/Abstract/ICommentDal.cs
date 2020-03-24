using EST.Mp.Core.DataAccess;
using EST.Mp.Entities.Concrete;

namespace EST.Mp.DataAccess.Abstract
{
    public interface ICommentDal : IEntityRepository<Comments>
    {
        //yorum ile ilgili özel operasyonlar "join" gibi burada gerçekleşir.
    }
}
