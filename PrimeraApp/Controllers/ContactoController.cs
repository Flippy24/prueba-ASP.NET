using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebGrease.Css.Ast.Selectors;

namespace PrimeraApp.Controllers
{
    public class ContactoController : Controller
    {
     

        public ActionResult Index()
        {
            ViewBag.Message = "Contáctese con nosotros";

            return View();
        }
        //Acá validar datos 
        
        public ActionResult Create()
        {
           return View();
        }




    }
}