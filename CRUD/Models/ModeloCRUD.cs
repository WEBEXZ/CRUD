using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class ModeloCRUD
    {
        //Constructor
        public ModeloCRUD()
        {
            empleado = new Employee();
            listaEmpleados = new List<Employee>();
        }
        //Variables a utilizar
        public Employee empleado { get; set; }
        public List<Employee> listaEmpleados { get; set; }
        public bool status { get; set; }
    }
}