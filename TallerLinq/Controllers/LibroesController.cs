using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TallerLinq.Models;

namespace TallerLinq.Controllers
{
    public class LibroesController : Controller
    {
        private readonly LibroDbContext _context;

        public LibroesController(LibroDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Obtener todos los libros con sus autores
            var libros = _context.Libros.Include(l => l.Autor).ToList();

            // Pasar los datos a la vista
            return View(libros);
        }

        public IActionResult Detalles(int id)
        {
            // Obtener un libro específico con su autor
            var libro = _context.Libros.Include(l => l.Autor).FirstOrDefault(l => l.Id == id);

            // Si el libro no existe, retornar un error 404
            if (libro == null)
            {
                return NotFound();
            }

            // Pasar los datos a la vista
            return View(libro);
        }
    }
}
