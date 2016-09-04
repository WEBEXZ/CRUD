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

        public ActionResult Index()
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            mdl.listaEmpleados = repo.getEmpleados();
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
                return RedirectToAction("Index");
            else
                return View(mdl);
        }

        public ActionResult EliminarEmpleado(int id)
        {
            ModeloCRUD mdl = new ModeloCRUD();
            RepoCRUD repo = new RepoCRUD();
            mdl.status = repo.eliminarEmpleado(id);
            return RedirectToAction("Index", mdl);
        }
    }
}
