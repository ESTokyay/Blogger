using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EST.Mp.Business.Abstract;
using EST.Mp.DataAccess.Abstract;
using EST.Mp.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EST.Mp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //Business katmanından çekilecek.   (business katmanı hazırlandı ve tekrar düzenlendi.)
        private readonly ICategoryServices _categoriesServices;

        public HomeController(ICategoryServices categoryServices)
        {
            _categoriesServices = categoryServices;
        }



        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Category(string test)
        {
            var categories = _categoriesServices.GetList(i=>i.CategoryName==test).Select(i=>i.CategoryName).ToList();
            return View(categories);
        }

        //[HttpPost]
        //public IActionResult Index(LoginModel model)
        //{
        //    _userService.Add(new Users { UserEmail = model.UserEmail, Password = model.Password });   //Login ekranında Kullanıcı email ve passwoed kayıt ediyor.
        //    return View();
        //}
    }
}