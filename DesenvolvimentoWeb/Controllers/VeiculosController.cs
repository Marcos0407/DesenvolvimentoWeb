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


        // Get
        public IActionResult Create() {
            return View();
        }


        // Push
        [HttpPost]
        public async Task<IActionResult> Create(Veiculo veiculo) {

            if ((ModelState.IsValid)) {
                    
                _context.Veiculos.Add(veiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            

            return View(veiculo);
        }



        // editar dados
        // GET
        public async Task<IActionResult> Edit(int? id) {
                
            if(id == null) {
                return  NotFound();
            }

            var dados = await _context.Veiculos.FindAsync(id);


            if(dados == null) {
                return NotFound();
            }

            return View(dados);

        }



        // editar dados
        // POST
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Veiculo veiculo) {
                
            if(id != veiculo.Id) {
                return NotFound();
            }

            if(ModelState.IsValid) {
                _context.Veiculos.Update(veiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();

        }





    }

}
