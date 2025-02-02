﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace examen_jcgubbins
{
    public class Jugador : Person
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
        public override void Verinformacionpersona()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Puntos de ataque: " + Puntosataque);
            Console.WriteLine("Puntos de defensa: " + Puntosdefensa);
        }

        public delegate void AvisarLesionEventHandler(object source, AvisarLesionEventArgs args);
        public event AvisarLesionEventHandler Lesionavisada;
        protected virtual void Onavisarlesion()
        {
            if (Lesionavisada != null)
            {
                Lesionavisada(this, new AvisarLesionEventArgs());
            }

        } //La cual se gatilla en la clase partido, El partido avisara al entrenador quien hara el cambio.
    }

        
}
