using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_jcgubbins
{
    public class Entrenador: Person
    {
        private int puntostactica;

        public int Puntostactica { get => puntostactica; set => puntostactica = value; }
        public Entrenador(string nombre, int edad, string nacion, string sueldo, int puntost)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacion = nacion;
            this.Sueldo = sueldo;
            this.Puntostactica = puntost;

        }
        public override void Verinformacionpersona()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Puntos de tactica: " + Puntostactica);
        }
        public void Cambiarjugador(Jugador j)
        {

        }
       
    }
}
