using EST.Mp.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EST.Mp.WebUI.ViewComponents
{
   
    public class CategoryMenu:ViewComponent
    {
        private readonly ICategoryServices _categoriesServices;
        public CategoryMenu(ICategoryServices categoriesServices)
        {
            _categoriesServices = categoriesServices;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoriesServices.GetList().Select(i=>i.CategoryName);
            return View(categories);
        }
    }

}
