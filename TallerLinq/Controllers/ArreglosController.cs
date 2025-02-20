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
    public class ArreglosController : Controller
    {
        public IActionResult Unidimensional()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            return View(numeros);
        }

        public IActionResult Bidimensional()
        {
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            return View(matriz);
        }
    }
}
