using Biblioteca.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using TesteCampos.Models;

namespace TesteCampos.Controllers
{
    public class ClienteController : Controller
    {
        readonly private SistemaDbContext _dataBase;

        public ClienteController(SistemaDbContext dataBase)
        {
            _dataBase = dataBase;
        }
        public IActionResult Cliente()
        {
            IEnumerable<ClienteModel> cliente = _dataBase.tbcliente;
            return View(cliente);
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

            ClienteModel cliente = _dataBase.tbcliente.FirstOrDefault(x => x.idCliente == id);

            if (cliente == null) { return NotFound(); }

            return View(cliente);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0) { return NotFound(); }
            ClienteModel cliente = _dataBase.tbcliente.FirstOrDefault(x => x.idCliente == id);
            if (cliente == null) { return NotFound(); }

            return View(cliente);

        }

        [HttpPost]
        public IActionResult Cadastrar(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {
                _dataBase.tbcliente.Add(cliente);
                _dataBase.SaveChanges();

                return RedirectToAction("Cliente");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Editar(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {
                _dataBase.tbcliente.Update(cliente);
                _dataBase.SaveChanges();

                return RedirectToAction("Cliente");
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Excluir(ClienteModel cliente)
        {
            if(cliente == null) { return NotFound(); }
            _dataBase.Remove(cliente);
            _dataBase.SaveChanges();

            return RedirectToAction("Cliente");
        }
    }
}
