using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class WebApiController : ApiController
    {
        [System.Web.Http.HttpPost]
        public JsonResult LoadEdit([FromBody] string bookId)
        {
            var context = new BookContext();
            var id = Convert.ToInt32(bookId);
            var book = context.BOOKS.FirstOrDefault(c => c.BOOKID == id);
            var cat = context.CATEGORIES.FirstOrDefault(v => v.CATEGORYID == id);
            return new JsonResult()
            {
                Data = new
                {
                    name = book.BOOKNAME ?? "",
                    author = book.AUTHOR,
                    isbn = book.ISBN,
                    category = cat.CATEGORYNAME
                },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [System.Web.Http.HttpPost]
        public JsonResult Save(BOOKS book)
        {
            var context = new BookContext();
            if (book.BOOKID == 0)
                context.AddBook(book);
            else
                context.EditBook(book);
            return null;
        }

        [System.Web.Mvc.HttpPost]
        public JsonResult Delete([FromBody] string pageId)
        {
            var context = new BookContext();
            context.DeleteBook(Convert.ToInt32(pageId));
            return null;
        }
    }
}
