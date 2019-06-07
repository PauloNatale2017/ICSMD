using Domain.Entities.EntitiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDM.WEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly Domain.Core.Repository.CadastroRepository _cadastrar = new Domain.Core.Repository.CadastroRepository();

        public ActionResult Index()
        {
           
            //SERVICE.Atumatizations.Importa _import = new SERVICE.Atumatizations.Importa();
            //List<Cadastro> entityList = _import.ImportExcel("");
            //foreach (var item in entityList){
            //    _cadastrar.Add(item); 
            //} 
            ViewBag.Title = "Home Page";
            return View();
        }


        public ActionResult VisualizarRegistros()
        {
            List<Cadastro> model = _cadastrar.GetAll().ToList<Cadastro>();
            return View(model);
        }
    }
}
