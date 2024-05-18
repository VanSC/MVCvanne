using MVCvanne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCvanne.Controllers
{
    public class PeopleController : Controller
    {
        public List<PearsonModel> people = new List<PearsonModel>();
        // GET: People
        public ActionResult Index()
        {
            people.Add(new PearsonModel
            {
                FirstName = "Vanessa",
                LastName = "Choque",
                Age = 21,
                Id = 1
            });
            return View(people);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: People/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(PearsonModel pearson)
        {
            try
            {
                // TODO: Add insert logic here
                // validaciones de dominio, son validaciones que se dan fuera del modelo de negocio. como es la edad, sueldo, y fn

                people.Add(pearson);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: People/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
