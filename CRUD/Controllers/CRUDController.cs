using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class CRUDController : Controller
    {
        // GET: /CRUD/

        public ActionResult Empleados()
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            mdl.listaEmpleados = repo.getEmpleados();
            return View(mdl);
        }

        public ActionResult Productos()
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            mdl.listaProductos = repo.getProductos();
            return View(mdl);
        }

        public ActionResult FormularioEmpleado(int id)
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            if (id != 0)
                mdl.empleado = repo.getEmpleado(id);
            return View(mdl);
        }

        public ActionResult FormularioProducto(int id)
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            if (id != 0)
                mdl.producto = repo.getProducto(id);
            return View(mdl);
        }

        [HttpPost]
        public ActionResult FormularioEmpleado(ModeloCRUD mdl)
        {
            RepoCRUD repo = new RepoCRUD();
            if (mdl.empleado.EmployeeID != 0)
            {
                mdl.status = repo.editarEmpleado(mdl.empleado);
            }
            else
            {
                mdl.status = repo.insertarEmpleado(mdl.empleado);
            }
            if (mdl.status == true)
            {
                mdl.mensaje = "Guardado con éxito";
                mdl.listaEmpleados = repo.getEmpleados();
                return View("Empleados", mdl);
            }
            else
            {
                mdl.mensaje = "Error al guardar";
                return View(mdl);
            }
        }

        [HttpPost]
        public ActionResult FormularioProducto(ModeloCRUD mdl)
        {
            RepoCRUD repo = new RepoCRUD();
            if (mdl.producto.ProductID != 0)
            {
                mdl.status = repo.editarProducto(mdl.producto);
            }
            else
            {
                mdl.status = repo.insertarProducto(mdl.producto);
            }
            if (mdl.status == true)
            {
                mdl.mensaje = "Guardado con éxito";
                mdl.listaProductos = repo.getProductos();
                return View("Productos", mdl);
            }
            else
            {
                mdl.mensaje = "Error al guardar";
                return View(mdl);
            }
        }

        public ActionResult EliminarEmpleado(int id)
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            mdl.status = repo.eliminarEmpleado(id);
            return RedirectToAction("Empleados", mdl);
        }

        public ActionResult EliminarProducto(int id)
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            mdl.status = repo.eliminarProducto(id);
            return RedirectToAction("Productos", mdl);
        }
    }
}
