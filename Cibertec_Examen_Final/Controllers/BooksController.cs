using Cibertec_Examen_Final.DataAccess;
using Cibertec_Examen_Final.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cibertec_Examen_Final.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        // GET: Books
        private BooksData _bookData = new BooksData();

        public ActionResult Index()
        {
            return View(_bookData.GetList());
        }

        public ActionResult Create()
        {
            return View(new Books());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Books author)
        {
            //Primero
            if (ModelState.IsValid)
            {
                _bookData.Add(author);
                return RedirectToAction("Index");
            }
            return View();
        }


        //Edit
        public ActionResult Edit(int id)
        {


            var Books = _bookData.GetBookId(id);
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
                _bookData.Update(Books);
                return RedirectToAction("Index");
            }
            return View();
        }


        //Delete
        public ActionResult Delete(int id)
        {


            var Books = _bookData.GetBookId(id);
            if (Books == null)
                RedirectToAction("Index");
            return View(Books);

        }

        //Edit Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Books Books)
        {

            if (_bookData.Delete(Books) > 0)
                return RedirectToAction("Index");

            return View();
        }
    }
}