using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_jcgubbins
{
    public abstract class Person
    {
        private string nombre;
        private int edad;
        public string nacion;
        private string sueldo;

        protected string Nacion { get => nacion; set => nacion = value; }
        protected int Edad { get => edad; set => edad = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Sueldo { get => sueldo; set => sueldo = value; }

    }
}
