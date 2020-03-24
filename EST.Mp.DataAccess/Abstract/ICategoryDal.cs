using EST.Mp.Core.DataAccess;
using EST.Mp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EST.Mp.DataAccess.Abstract
{
    public  interface ICategoryDal: IEntityRepository<Categories>
    {
        //Category ile ilgili özel operasyonlar "join" gibi burada gerçekleşir.
    }
}
