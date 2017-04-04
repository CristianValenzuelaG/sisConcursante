using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HerramientasDatas.Modelo;
using sisConcurso.Manager;
using siWeb.ManagerWeb;


namespace siWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string word = "", string m = "")
        {
            ViewBag.DatosC = CandidataManage.Buscar(word, true, m);
            ViewBag.DatosM = MunicipioManage.getAll();
            ViewBag.word = word;
            return View();
        }
        public ActionResult Like(int pkCandidata)
        {
            CandidataManage.Like(pkCandidata);
            return RedirectToAction("");
        }
    }
}