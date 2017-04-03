using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HerramientasData.Modelo;
using siWeb.ManagerWeb;


namespace siWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string txtValor = "")
        {
            List<candidata> datos = candidataManager.Listar(txtValor);
            ViewBag.datos = datos;
            ViewBag.txtValor = txtValor;
            return View();
        }
    }
}