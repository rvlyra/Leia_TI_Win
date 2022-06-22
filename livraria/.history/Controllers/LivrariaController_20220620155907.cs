using livraria.Models;
using Microsoft.AspNetCore.Mvc;

namespace livraria.Controllers
{
    public class LivrariaController :Controller
    {
        private readonly AppDbContext _context;

        public LivrariaController(AppDbContext context)
        {
            _context = context;
        }

        // exibir lista de livros
        [HttpGet]
        public IActionResult Index()
        {
            var books = _context.Livros.ToList();
            return View(books);
        }
        // Criar ou cadatrar um novo livro
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Livro livro)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _context.Livros.Add(livro);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Algo deu errado no processo. Verifique o status de erro: {ex.Message}");
                }
            }
        }

    }
}