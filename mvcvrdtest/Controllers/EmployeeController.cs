using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
namespace mvcvrdtest.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Employee e1)
        {
            // DAL.Employee obj = new DAL.Employee();
            DAL.Employee1 obj = new DAL.Employee1();
            int i = obj.AddEmpoyee(e1);
            if (i == 1)
            {
                ViewBag.Message = "Record is inserted";
            }
            else
            {
                ViewBag.Message = "Failed";
            }
            return View();
        }
    }
}