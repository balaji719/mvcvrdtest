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
        DAL.Employee1 obj = new DAL.Employee1();

        // GET: Employee
        public ActionResult Index()
        {
            TempData["ie"] = obj.GetEmps().ToList();
            TempData.Keep();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Employee e1, string b1)
        {
            // DAL.Employee1 obj = new DAL.Employee1();

            if (b1 == "Save")
            {
                int i = obj.AddEmpoyee(e1);
                if (i == 1)
                {
                    ViewBag.Message = "Record is inserted";
                }
                else
                {
                    ViewBag.Message = "Failed";
                }

            }
            else if (b1 == "Delete")
            {
                int i = obj.DeleteEmpoyee(e1);
                if (i == 1)
                {
                    ViewBag.Message = "Record is deleted";
                }
                else
                {
                    ViewBag.Message = "Failed";
                }

            }

            else if (b1 == "Update")
            {
                int i = obj.UpdateEmpoyee(e1);
                if (i == 1)
                {
                    ViewBag.Message = "Record is updataed";
                }
                else
                {
                    ViewBag.Message = " update Failed";
                }

            }         
                       
            return RedirectToAction("Index", "Employee");
        }
    }

}
