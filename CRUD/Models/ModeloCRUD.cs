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
            estado = new Cat_Estado();
            municipio = new Cat_Municipio();
            listaEmpleados = new List<Employee>();
            listaProductos = new List<Product>();
            listaCategorias = new List<Category>();
            listaProveedores = new List<Supplier>();
            listaEstados = new List<Cat_Estado>();
            listaMunicipios = new List<Cat_Municipio>();
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
        public Cat_Estado estado { get; set; }
        public List<Cat_Estado> listaEstados { get; set; }
        public Cat_Municipio municipio { get; set; }
        public List<Cat_Municipio> listaMunicipios { get; set; }
    }
}