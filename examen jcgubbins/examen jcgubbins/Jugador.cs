using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace examen_jcgubbins
{
    public class Jugador: Person
    {
        private int puntosataque;
        private int puntosdefensa;
        private int numerocamiseta;

        public int Puntosataque { get => puntosataque; set => puntosataque = value; }
        public int Puntosdefensa { get => puntosdefensa; set => puntosdefensa = value; }
        public int Numerocamiseta { get => numerocamiseta; set => numerocamiseta = value; }

        public Jugador(string nombre, int edad, string nacion, string sueldo, int puntosa, int puntosd, int numerocamiseta)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacion = nacion;
            this.Sueldo = sueldo;
            this.Puntosataque = puntosa;
            this.Puntosdefensa = puntosd;
            this.Numerocamiseta = numerocamiseta;
        }

    }
}
