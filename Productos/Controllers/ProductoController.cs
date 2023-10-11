using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Productos.Models;
using Productos.Util;

namespace Productos.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public IActionResult Index()
        {
            return View(Util.Utils.ListaProducto);
        }

        // GET: Producto/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            int id = Util.Utils.ListaProducto.Count()+1;
            producto.IdProducto = id;
            Util.Utils.ListaProducto.Add(producto);
            return RedirectToAction("Index");
        }

        // GET: Producto/Edit/5
        public IActionResult Edit(int idProducto)
        {
            Producto producto = Utils.ListaProducto.Find(x => x.IdProducto == idProducto);
            if (producto != null)
            {
                return View("Producto");
            }
            return RedirectToAction("Index");
        }

        // GET: Producto/Delete/5
        public IActionResult Delete(int idProducto)
        {

            Producto producto = Utils.ListaProducto.Find(x => x.IdProducto == idProducto);
            if (producto != null)
            {
                Utils.ListaProducto.Remove(producto);
            }
            return RedirectToAction("Index");
        }


      
    }
}