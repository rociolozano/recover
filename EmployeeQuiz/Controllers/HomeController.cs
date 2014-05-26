using EmployeeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(Employe emp)
        {

            //Creo el objeto del modelo de datos
            Payrolldm nomina = new Payrolldm(
                @"C:\Users\rocio\Documents\Visual Studio 2012\Projects\Recover\EmployeeQuiz\Models\EmployeeDb.csv");
   
            //busco el empleado dado su id
            
            var empleado=nomina.GetEmployeById(emp.Id);

            double val = double.Parse(emp.Id);

            if (val <= 5 && val >=1)
            {
                return View("WorkerView", empleado);
            }
            else { return View("error"); }
        }




    }
}
