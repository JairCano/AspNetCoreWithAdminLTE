using AspNetCoreWithAdminLTE.Data;
using AspNetCoreWithAdminLTE.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithAdminLTE.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmpleadosController(ApplicationDbContext context)
        {
            _context = context;
        }
        //TODO: 7. Creamos el Controlador
        public IActionResult Index()
        {
            IEnumerable<Empleados> listEmpleados = _context.Empleados;
            return View(listEmpleados);
        }

        //HTTP GET CREATE
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //HTTP GET CREATE
        [HttpPost]
        public IActionResult Create(Empleados empleados)
        {
            if (ModelState.IsValid)
            {
                _context.Empleados.Add(empleados);
                _context.SaveChanges();

                TempData["mensaje"] = "El Empleado Se Ha Guardado Correctamente";
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

            var empleados = _context.Empleados.Find(id);

            if (empleados == null)
            {
                return NotFound();
            }

            return View(empleados);
        }

       [HttpPost]
        public IActionResult Edit(Empleados empleados)
        {
            if (ModelState.IsValid)
            {
                _context.Empleados.Update(empleados);
                _context.SaveChanges();

                TempData["mensaje"] = "El Empleado Se Ha Actualizado Correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }

        //[HttpGet]
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }

        //    var empleados = _context.Empleados.Find(id);

        //    if (empleados == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(empleados);
        //}


        //[HttpPost]
        //public IActionResult DeleteEmpleados(int? id)
        //{

        //    var empleado = _context.Empleados.Find(id);

        //    if (empleado == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Empleados.Remove(empleado);
        //    _context.SaveChanges();

        //    TempData["mensaje"] = "El Empleado Se Ha Actualizado Correctamente";
        //    return RedirectToAction("Index");

        //}


    }
}
