using AspNetCoreWithAdminLTE.Data;
using AspNetCoreWithAdminLTE.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithAdminLTE.Controllers
{
    public class ProveedoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProveedoresController(ApplicationDbContext context)
        {
            _context = context;
        }
        //TODO: 7. Creamos el Controlador
        public IActionResult Index()
        {
            IEnumerable<Proveedores> listProveedores = _context.Proveedores;
            return View(listProveedores);
        }

        //HTTP GET CREATE
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //HTTP GET CREATE
        [HttpPost]
        public IActionResult Create(Proveedores proveedores)
        {
            if (ModelState.IsValid)
            {
                _context.Proveedores.Add(proveedores);
                _context.SaveChanges();

                TempData["mensaje"] = "El Proveedor Se Ha Guardado Correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var proveedores = _context.Proveedores.Find(id);

            if (proveedores == null)
            {
                return NotFound();
            }

            return View(proveedores);
        }

        [HttpPost]
        public IActionResult Edit(Proveedores proveedores)
        {
            if (ModelState.IsValid)
            {
                _context.Proveedores.Update(proveedores);
                _context.SaveChanges();

                TempData["mensaje"] = "El Proveedor Se Ha Actualizado Correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var proveedores = _context.Proveedores.Find(id);

            if (proveedores == null)
            {
                return NotFound();
            }

            return View(proveedores);
        }


        [HttpPost]
        public IActionResult DeleteProveedores(int? id)
        {

            var proveedores = _context.Proveedores.Find(id);

            if (proveedores == null)
            {
                return NotFound();
            }

            _context.Proveedores.Remove(proveedores);
            _context.SaveChanges();

            TempData["mensaje"] = "El Proveedor Se Ha eliminado Correctamente";
            return RedirectToAction("Index");

        }

    }
}

