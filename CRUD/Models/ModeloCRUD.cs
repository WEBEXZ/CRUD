using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Models
{
    public class ModeloCRUD
    {
        //Constructor
        public ModeloCRUD()
        {
            empleado = new Employee();
            producto = new Product();
            categoria = new Category();
            proveedor = new Supplier();
            listaEmpleados = new List<Employee>();
            listaProductos = new List<Product>();
            listaCategorias = new List<Category>();
            listaProveedores = new List<Supplier>();
        }

        //Variables a utilizar
        public Employee empleado { get; set; }
        public List<Employee> listaEmpleados { get; set; }
        public bool status { get; set; }
        public string mensaje { get; set; }
        public Product producto { get; set; }
        public List<Product> listaProductos { get; set; }
        public Category categoria { get; set; }
        public List<Category> listaCategorias { get; set; }
        public Supplier proveedor { get; set; }
        public List<Supplier> listaProveedores { get; set; }
    }
}