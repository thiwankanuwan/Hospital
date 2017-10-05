using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.DataConnection;
using Core.Entity;

namespace dental.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult AddForm(Form Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   DataContext  EmpRepo = new DataContext();

                    if (EmpRepo.AddForm(Emp))
                    {
                        ViewBag.Message = "Form details added successfully";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}