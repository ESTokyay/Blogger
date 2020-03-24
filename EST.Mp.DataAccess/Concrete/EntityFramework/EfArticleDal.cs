using EST.Mp.Core.DataAccess.EntityFramework;
using EST.Mp.DataAccess.Abstract;
using EST.Mp.Entities.Concrete;

namespace EST.Mp.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<Articles, MpContext>, IArticleDal
    {
        //IArticleDal article = new EfArticleDal();
    }
}
