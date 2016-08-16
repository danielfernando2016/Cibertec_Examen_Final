using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cibertec_Examen_Final.DataAccess;
using Cibertec_Examen_Final.Model;

namespace Cibertec_Examen_Final.Areas.Authores.Controllers
{
    public class AuthorsController : Controller
    {
        // GET: Authores/Authors
        private AuthorsData _authorsData = new AuthorsData();

        public ActionResult Index()
        {
            return View(_authorsData.GetList());
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
                _authorsData.Add(author);
                return RedirectToAction("Index");
            }
            return View();
        }

        //Edit
        public ActionResult Edit(int id)
        {


            var Authors = _authorsData.GetAuthorId(id);
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
                _authorsData.Update(Authors);
                return RedirectToAction("Index");
            }
            return View();
        }


        //Delete
        public ActionResult Delete(int id)
        {


            var Authors = _authorsData.GetAuthorId(id);
            if (Authors == null)
                RedirectToAction("Index");
            return View(Authors);

        }

        //Edit Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Authors Authors)
        {

            if (_authorsData.Delete(Authors) > 0)
                return RedirectToAction("Index");

            return View();
        }
    }
}