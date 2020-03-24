using EST.Mp.Core.DataAccess.EntityFramework;
using EST.Mp.DataAccess.Abstract;
using EST.Mp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EST.Mp.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal: EfEntityRepositoryBase<Categories,MpContext>,ICategoryDal
    {

    }
}
