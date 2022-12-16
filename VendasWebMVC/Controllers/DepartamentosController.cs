using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendasWebMVC.Models;

namespace VendasWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamentos> list = new List<Departamentos>();
            list.Add(new Departamentos { Id = 1, Nome = "Eletronicos" });//adicionar a lista
            list.Add(new Departamentos { Id = 2, Nome = "Fashion" });
            return View(list);// enviar a lista da controller para a view
        }
    }
}
