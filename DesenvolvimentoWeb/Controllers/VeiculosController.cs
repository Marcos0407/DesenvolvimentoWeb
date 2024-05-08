using DesenvolvimentoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesenvolvimentoWeb.Controllers {
    public class VeiculosController : Controller {
            
        private readonly AppDbContext _context;
        public VeiculosController(AppDbContext context) { 
            _context = context;
        }


        public async Task<IActionResult> Index() {

            var dados = await _context.Veiculos.ToListAsync();
            return View(dados);

        }

    }

}
