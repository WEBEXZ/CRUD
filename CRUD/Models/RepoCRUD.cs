using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class RepoCRUD
    {
        //Instancia de la base de datos
        public DB_NorthwindDataContext db = new DB_NorthwindDataContext();

        //Obtener un empleado por ID
        public Employee getEmpleado(int id)
        {
            Employee empleado = new Employee();
            empleado = db.Employees.SingleOrDefault(m => m.EmployeeID == id);
            return empleado;
        }

        //Obtener un producto por ID
        public Product getProducto(int id)
        {
            Product producto = new Product();
            producto = db.Products.SingleOrDefault(p => p.ProductID == id);
            return producto;
        }

        //Obtener lista de empleados
        public List<Employee> getEmpleados()
        {
            List<Employee> lista = new List<Employee>();
            lista = db.Employees.ToList();
            return lista;
        }

        //Obtener lista de productos
        public List<Product> getProductos()
        {
            List<Product> lista = new List<Product>();
            lista = db.Products.ToList();
            return lista;
        }

        //Insertar un empleado
        public Boolean insertarEmpleado(Employee e)
        {
            try
            {
                db.Employees.InsertOnSubmit(e);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Insertar un producto
        public Boolean insertarProducto(Product p)
        {
            try
            {
                db.Products.InsertOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Editar un empleado
        public bool editarEmpleado(Employee e)
        {
            Employee empleadoActual = db.Employees.SingleOrDefault(m => m.EmployeeID == e.EmployeeID);
            try
            {
                empleadoActual.LastName = e.LastName;
                empleadoActual.FirstName = e.FirstName;
                empleadoActual.Title = e.Title;
                empleadoActual.TitleOfCourtesy = e.TitleOfCourtesy;
                empleadoActual.BirthDate = e.BirthDate;
                empleadoActual.HireDate = e.HireDate;
                empleadoActual.Address = e.Address;
                empleadoActual.City = e.City;
                empleadoActual.Region = e.Region;
                empleadoActual.PostalCode = e.PostalCode;
                empleadoActual.Country = e.Country;
                empleadoActual.HomePhone = e.HomePhone;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Editar un producto
        public bool editarProducto(Product p)
        {
            Product productoActual = db.Products.SingleOrDefault(m => m.ProductID == p.ProductID);
            try
            {
                productoActual.ProductName = p.ProductName;
                productoActual.UnitPrice = p.UnitPrice;
                productoActual.UnitsInStock = p.UnitsInStock;
                productoActual.UnitsOnOrder = p.UnitsOnOrder;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Eliminar un empleado por ID
        public bool eliminarEmpleado(int id)
        {
            Employee empleado = db.Employees.SingleOrDefault(m => m.EmployeeID == id);
            try
            {
                db.Employees.DeleteOnSubmit(empleado);
                db.SubmitChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        //Eliminar un producto por ID
        public bool eliminarProducto(int id)
        {
            Product producto = db.Products.SingleOrDefault(m => m.ProductID == id);
            try
            {
                db.Products.DeleteOnSubmit(producto);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}