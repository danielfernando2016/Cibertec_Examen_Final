using Cibertec_Examen_Final.DataAccess;
using Cibertec_Examen_Final.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cibertec_Examen_Final.Controllers
{
    public class AuthorsController : Controller
    {
        // GET: Authors
        private AuthorsData _authorData = new AuthorsData();

        public ActionResult Index()
        {
            return View(_authorData.GetList());
        }

        public ActionResult Create()
        {
            return View(new Authors());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Authors author)
        {
            //Primero
            if (ModelState.IsValid)
            {
                _authorData.Add(author);
                return RedirectToAction("Index");
            }
            return View();
        }


        //Edit
        public ActionResult Edit(int id)
        {


            var Authors = _authorData.GetAuthorId(id);
            if (Authors == null)
                RedirectToAction("Index");
            return View(Authors);

        }

        //Edit Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Authors Authors)
        {
            //Primero
            if (ModelState.IsValid)
            {
                _authorData.Update(Authors);
                return RedirectToAction("Index");
            }
            return View();
        }


        //Delete
        public ActionResult Delete(int id)
        {


            var Authors = _authorData.GetAuthorId(id);
            if (Authors == null)
                RedirectToAction("Index");
            return View(Authors);

        }

        //Edit Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Authors Authors)
        {

            if (_authorData.Delete(Authors) > 0)
                return RedirectToAction("Index");

            return View();
        }



    }
}