using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_jcgubbins
{
    public class Medico: Person
    {
        private int puntosexperiencia;

        public int Puntosexperiencia { get => puntosexperiencia; set => puntosexperiencia = value; }
        public Medico(string nombre, int edad, string nacion, string sueldo, int puntose)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacion = nacion;
            this.Sueldo = sueldo;
            this.Puntosexperiencia = puntose;

        }
    }
}
