using Biblioteca.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteCampos.Models;

namespace TesteCampos.Controllers
{
    public class VendaController : Controller
    {

        readonly private SistemaDbContext _dataBase;

        public VendaController(SistemaDbContext dataBase)
        {
            _dataBase = dataBase;
        }

        public IActionResult Venda()
        {
            IEnumerable<VendaModel> venda = _dataBase.tbvenda;

            return View(venda);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0) { return NotFound(); }

            VendaModel venda = _dataBase.tbvenda.FirstOrDefault(x => x.idVenda == id);

            if (venda == null) { return NotFound(); }

            return View(venda);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0) { return NotFound(); }
            VendaModel venda = _dataBase.tbvenda.FirstOrDefault(x => x.idVenda == id);
            if (venda == null) { return NotFound(); }

            return View(venda);

        }

        [HttpPost]
        public IActionResult Cadastrar(VendaModel venda)
        {
            if (ModelState.IsValid)
            {
                _dataBase.tbvenda.Add(venda);
                _dataBase.SaveChanges();

                return RedirectToAction("Venda");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Editar(VendaModel venda)
        {
            if (ModelState.IsValid)
            {
                _dataBase.tbvenda.Update(venda);
                _dataBase.SaveChanges();

                return RedirectToAction("Venda");
            }

            return View(venda);
        }

        [HttpPost]
        public IActionResult Excluir(VendaModel venda)
        {
            if (venda == null) { return NotFound(); }
            _dataBase.Remove(venda);
            _dataBase.SaveChanges();

            return RedirectToAction("Venda");
        }

    }
}
