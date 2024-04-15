using Biblioteca.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteCampos.Models;

namespace TesteCampos.Controllers
{
    public class ProdutoController : Controller
    {
        readonly private SistemaDbContext _dataBase;

        public ProdutoController(SistemaDbContext dataBase)
        {
            _dataBase = dataBase;
        }
        public IActionResult Produto()
        {
            IEnumerable<ProdutoModel> produtos = _dataBase.tbproduto;

            return View(produtos);
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
            ProdutoModel produto = _dataBase.tbproduto.FirstOrDefault(x => x.idProduto == id);
            if (produto == null) { return NotFound(); }

            return View(produto);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0) { return NotFound(); }
            ProdutoModel produto = _dataBase.tbproduto.FirstOrDefault(x => x.idProduto == id);
            if (produto == null) { return NotFound(); }

            return View(produto);
        }

        [HttpPost]
        public IActionResult Cadastrar(ProdutoModel produto)
        {
            if (ModelState.IsValid)
            {
                _dataBase.tbproduto.Add(produto);
                _dataBase.SaveChanges();

                return RedirectToAction("Produto");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Editar(ProdutoModel produto)
        {
            if (ModelState.IsValid)
            {
                _dataBase.tbproduto.Update(produto);
                _dataBase.SaveChanges();

                return RedirectToAction("Produto");
            }

            return View(produto);
        }
        [HttpPost]
        public IActionResult Excluir(ProdutoModel produto)
        {
            if (produto == null) { return NotFound(); }
            _dataBase.Remove(produto);
            _dataBase.SaveChanges();

            return RedirectToAction("Produto");
        }

    }
}
