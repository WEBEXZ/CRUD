using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        //Obtener una categoria por ID
        public Category getCategoria(int id)
        {
            Category categoria = new Category();
            categoria = db.Categories.SingleOrDefault(p => p.CategoryID == id);
            return categoria;
        }

        //Obtener un proveedor por ID
        public Supplier getProveedor(int id)
        {
            Supplier proveedor = new Supplier();
            proveedor = db.Suppliers.SingleOrDefault(p => p.SupplierID == id);
            return proveedor;
        }

        //Obtener un estado por ID
        public Cat_Estado getEstado(int id)
        {
            Cat_Estado proveedor = new Cat_Estado();
            proveedor = db.Cat_Estados.SingleOrDefault(p => p.id_estado == id);
            return proveedor;
        }

        //Obtener un municipio por ID
        public Cat_Municipio getMunicipio(int id)
        {
            Cat_Municipio proveedor = new Cat_Municipio();
            proveedor = db.Cat_Municipios.SingleOrDefault(p => p.id_municipio == id);
            return proveedor;
        }

        //Obtener municipios por ID del estado
        public List<Cat_Municipio> getMunicipiosByEstado(int id) 
        { 
            List<Cat_Municipio> m = new List<Cat_Municipio>();
            m = db.Cat_Municipios.Where(x => x.id_estado == id).ToList();
            return m;
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

        //Obtener lista de categorias
        public List<Category> getCategorias()
        {
            List<Category> lista = new List<Category>();
            lista = db.Categories.ToList();
            return lista;
        }

        //Obtener lista de proveedores
        public List<Supplier> getProveedores()
        {
            List<Supplier> lista = new List<Supplier>();
            lista = db.Suppliers.ToList();
            return lista;
        }

        //Obtener lista de estados
        public List<Cat_Estado> getEstados()
        {
            List<Cat_Estado> lista = new List<Cat_Estado>();
            lista = db.Cat_Estados.ToList();
            return lista;
        }

        //Obtener lista de municipios
        public List<Cat_Municipio> getMunicipios()
        {
            List<Cat_Municipio> lista = new List<Cat_Municipio>();
            lista = db.Cat_Municipios.ToList();
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

        //Insertar una categoria
        public Boolean insertarCategoria(Category c)
        {
            try
            {
                db.Categories.InsertOnSubmit(c);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Insertar un proveedor
        public Boolean insertarProveedor(Supplier p)
        {
            try
            {
                db.Suppliers.InsertOnSubmit(p);
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
                productoActual.CategoryID = p.CategoryID;
                productoActual.SupplierID = p.SupplierID;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Editar una categoria
        public bool editarCategoria(Category c)
        {
            Category categoriactual = db.Categories.SingleOrDefault(m => m.CategoryID == c.CategoryID);
            try
            {
                categoriactual.CategoryName = c.CategoryName;
                categoriactual.Description = c.Description;
                categoriactual.Picture = c.Picture;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Editar un proveedor
        public bool editarProveedor(Supplier p)
        {
            Supplier proveedorActual = db.Suppliers.SingleOrDefault(m => m.SupplierID == p.SupplierID);
            try
            {
                proveedorActual.CompanyName = p.CompanyName;
                proveedorActual.ContactName = p.ContactName;
                proveedorActual.Address = p.Address;
                proveedorActual.Phone = p.Phone;
                proveedorActual.EstadoID = p.EstadoID;
                proveedorActual.MunicipioID = p.MunicipioID;
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

        //Eliminar una categoria por ID
        public bool eliminarCategoria(int id)
        {
            Category categoria = db.Categories.SingleOrDefault(m => m.CategoryID == id);
            try
            {
                db.Categories.DeleteOnSubmit(categoria);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Eliminar un proveedor por ID
        public bool eliminarProveedor(int id)
        {
            Supplier proveedor = db.Suppliers.SingleOrDefault(m => m.SupplierID == id);
            try
            {
                db.Suppliers.DeleteOnSubmit(proveedor);
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