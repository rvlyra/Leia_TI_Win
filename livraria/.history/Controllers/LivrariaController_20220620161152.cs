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

        
        [HttpGet]
        public IActionResult Index()
        {
            var books = _context.Livros.ToList();
            return View(books);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        
        [HttpPost]
        public async Task<ActionResult> Create(Livro livro)
        {
            if (ModelState.IsValid)
            {
                throw new ArgumentNullException(nameof(livro));
            }
        }
                

    }
}