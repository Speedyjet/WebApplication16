using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var context = new BookContext();
            ViewData["BookList"] = context.GetBookList();
            return View();
        }
        //TODO: индекс будет выводить все доступные книги с авторами и категориями
        //TODO: добавить гет в котором выведу вопрос о добавлении новой категории
        //TODO: добавить пост, в котором буду добавлять новую категорию

        //[HttpGet]
        //public ViewResult CreateNewCategory()
        //{
        //    //TODO: add view with a new category creation dialog
        //    return null; //View();
        //}

        //[HttpPost]
        //public ViewResult NewCategory()
        //{
        //    //TODO: add something here
        //    return null;
        //}
    }
}