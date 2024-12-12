using CamadaDeDados;
using System.Data.Entity;
using System;
using System.Web.Mvc;
using System.Linq;
using CamadaDeNegocios;

namespace GerenciamentoFuncionarios.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioRegraDeNegocio _funcionarioRN = new FuncionarioRegraDeNegocio();

        // Método de ação para listar todos funcionários
        public ActionResult Index()
        {
            ViewBag.ActivePage = "Index";
            var funcionarios = _funcionarioRN.GetAllFuncionarios();
            return View(funcionarios);
        }

        // Método de ação GET para a página de criação de funcionários no BD
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ActivePage = "Create";
            return View();
        }

        // Método de ação POST para publicar funcionario no BD
        [HttpPost]
        public ActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _funcionarioRN.AddFuncionario(funcionario);
                return RedirectToAction("Index");
            }
            
            return View(funcionario);
        }

        // Método de ação GET para a página de edição de funcionários no BD
        [HttpGet]
        public ActionResult Edit(int id) 
        {
            var funcionario = _funcionarioRN.GetFuncionarioById(id);

            if (funcionario == null)
                return HttpNotFound();

            return View(funcionario);
        }

        // Método de ação POST para edição de dados do funcionário
        [HttpPost]
        public ActionResult Edit(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _funcionarioRN.EditarFuncionario(funcionario);
                return RedirectToAction("Index");
            }
            return View(funcionario);
        }

        // Método de ação para excluir um funcionário do banco de dados
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var funcionario = _funcionarioRN.GetFuncionarioById(id);

            if (funcionario == null)
            {
                return HttpNotFound();
            }

            return View(funcionario);
        }

        // Método que confirma a exclusão do funcionário
        [HttpPost, ActionName("DeleteConfirmed")]
        public ActionResult DeleteConfirmed(int id)
        {
            _funcionarioRN.DeletarFuncionario(id);
            return RedirectToAction("Index");
        }

    }
}