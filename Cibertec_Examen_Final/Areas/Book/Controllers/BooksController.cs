using Cibertec_Examen_Final.DataAccess;
using Cibertec_Examen_Final.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cibertec_Examen_Final.Areas.Book.Controllers
{
    public class BooksController : Controller
    {
        // GET: Book/Books
        // GET: Authors
        private BooksData _booksData = new BooksData();

        public ActionResult Index()
        {
            return View(_booksData.GetList());
        }

        public ActionResult Create()
        {
            return View(new Books());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Books book)
        {
            //Primero
            if (ModelState.IsValid)
            {
                _booksData.Add(book);
                return RedirectToAction("Index");
            }
            return View();
        }

        //Edit
        public ActionResult Edit(int id)
        {


            var Books = _booksData.GetBookId(id);
            if (Books == null)
                RedirectToAction("Index");
            return View(Books);

        }

        //Edit Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Books Books)
        {
            //Primero
            if (ModelState.IsValid)
            {
                _booksData.Update(Books);
                return RedirectToAction("Index");
            }
            return View();
        }


        //Delete
        public ActionResult Delete(int id)
        {


            var Books = _booksData.GetBookId(id);
            if (Books == null)
                RedirectToAction("Index");
            return View(Books);

        }

        //Edit Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Books Books)
        {

            if (_booksData.Delete(Books) > 0)
                return RedirectToAction("Index");

            return View();
        }

    }
}