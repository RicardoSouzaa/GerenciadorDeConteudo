using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_GerenciadorDeConteudo.Controllers
{
    public class PaginasController : Controller
    {
        // GET: Paginas
        public ActionResult Index()
        {
            ViewBag.Paginas = new Pagina().Lista();
            return View();
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public void Criar()
        {
            var pagina = new Pagina();
            DateTime.TryParse(Request["data"], out DateTime data);
            pagina.Nome = Request["nome"];
            pagina.Data = data;
            pagina.Conteudo = Request["conteudo"];
            pagina.Save();
            Response.Redirect("/paginas");
        }

        public ActionResult Editar(int id)
        {
            var pagina = Pagina.BuscaPorId(id);
            ViewBag.Pagina = pagina;
            ViewResult viewResult = View(pagina);
            return viewResult;
        }

        [HttpPost]
        public void Alterar(int id)
        {
            try
            {
                var pagina = Pagina.BuscaPorId(id);

                DateTime.TryParse(Request["data"], out DateTime data);

                pagina.Nome = Request["nome"];
                pagina.Data = data;
                pagina.Conteudo = Request["conteudo"];
                pagina.Save();

                TempData["sucesso"] = "Página Alterada com Sucesso!";
            }
            catch (Exception)
            {
                TempData["erro"] = "A pagina não foi alterada.";
            }

            Response.Redirect("/paginas");
        }
    }
}