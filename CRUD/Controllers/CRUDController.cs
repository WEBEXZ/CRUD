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

        public ActionResult Categorias()
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            mdl.listaCategorias = repo.getCategorias();
            return View(mdl);
        }

        public ActionResult Proveedores()
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            mdl.listaProveedores = repo.getProveedores();
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

            ViewBag.nombreCategorias = new SelectList(repo.getCategorias(), "CategoryID", "CategoryName");
            ViewBag.nombreProveedores = new SelectList(repo.getProveedores(), "SupplierID", "CompanyName");
            return View(mdl);
        }

        public ActionResult FormularioCategoria(int id)
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            if (id != 0)
                mdl.categoria = repo.getCategoria(id);
            return View(mdl);
        }

        public ActionResult FormularioProveedor(int id)
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            if (id != 0)
                mdl.proveedor = repo.getProveedor(id);
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
            ModeloCRUD m = new ModeloCRUD();            
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
                mdl.listaProductos = repo.getProductos();
                mdl.mensaje = "Guardado con éxito";                
                return View("Productos", mdl);
            }
            else
            {
                mdl.mensaje = "Error al guardar";
                return View(mdl);
            }
        }

        [HttpPost]
        public ActionResult FormularioCategoria(ModeloCRUD mdl)
        {
            RepoCRUD repo = new RepoCRUD();
            if (mdl.categoria.CategoryID != 0)
            {
                mdl.status = repo.editarCategoria(mdl.categoria);
            }
            else
            {
                mdl.status = repo.insertarCategoria(mdl.categoria);
            }
            if (mdl.status == true)
            {
                mdl.mensaje = "Guardado con éxito";
                mdl.listaCategorias = repo.getCategorias();
                return View("Categorias", mdl);
            }
            else
            {
                mdl.mensaje = "Error al guardar";
                return View(mdl);
            }
        }

        [HttpPost]
        public ActionResult FormularioProveedor(ModeloCRUD mdl)
        {
            RepoCRUD repo = new RepoCRUD();
            if (mdl.proveedor.SupplierID != 0)
            {
                mdl.status = repo.editarProveedor(mdl.proveedor);
            }
            else
            {
                mdl.status = repo.insertarProveedor(mdl.proveedor);
            }
            if (mdl.status == true)
            {
                mdl.mensaje = "Guardado con éxito";
                mdl.listaProveedores = repo.getProveedores();
                return View("Proveedores", mdl);
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

        public ActionResult EliminarCategoria(int id)
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            mdl.status = repo.eliminarCategoria(id);
            return RedirectToAction("Categorias", mdl);
        }

        public ActionResult EliminarProveedor(int id)
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            mdl.status = repo.eliminarProveedor(id);
            return RedirectToAction("Proveedores", mdl);
        }
    }
}
