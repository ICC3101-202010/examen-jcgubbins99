using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace examen_jcgubbins
{
    public class Equipo
    {
        private string nombreequipo;
        private string tipodeequipo;
        private List<Jugador> jugadores;
        private Entrenador entrenador;
        private Medico medico;

        public string Nombreequipo { get => nombreequipo; set => nombreequipo = value; }
        public string Tipodeequipo { get => tipodeequipo; set => tipodeequipo = value; }
        public Entrenador Entrenador { get => entrenador; set => entrenador = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }

        public Equipo(string nombree, string tipoe, List<Jugador> jugador, Entrenador e, Medico m)
        {
            this.Nombreequipo = nombree;
            this.Tipodeequipo = tipoe;
            this.Entrenador = e;
            this.Medico = m;
            this.Jugadores = jugador;

        }
        
        public void Corroborarnacionalidad(List<Jugador> j)
        {
            string nacion = "si";
            foreach (Jugador jugador in j)
            {
                if (jugador.Nacion.ToLower() != j[0].Nacion.ToLower())
                {
                    nacion = "no";
                    break;
                
                }

                    
                
            }
        if (nacion == "si")
            {
                Console.WriteLine("");
                Console.WriteLine("Este equipo efectivamente pertenece a una seleccion nacional");
                Thread.Sleep(3000);
                

            }
        if (nacion == "no")
            {
                Console.WriteLine("");
                Console.WriteLine("Este equipo NO pertenece a una seleccion nacional, es un equipo de liga, se le cambiara su descripcion");
                Thread.Sleep(3000);
                this.Tipodeequipo = "Equipo de liga";
            }
        }
        public void Verinformacionequipo(Equipo e)
        {
            Console.WriteLine(" ===========");
            Console.WriteLine("EQUIPO: " + nombreequipo);
            Console.WriteLine(" ===========");
            Console.WriteLine("");
            Console.WriteLine(" ===========");
            Console.WriteLine(" TIPO E EQUIPO: " + tipodeequipo);
            Console.WriteLine(" ===========");
            Console.WriteLine("");
            Console.WriteLine(" ===========");
            Console.WriteLine(" JUGADORES");
            Console.WriteLine(" ===========");
            Console.WriteLine("");
            int n = 1;
            foreach (Jugador j in e.jugadores)
            {
                

                Console.WriteLine("JUGADOR " + n+":");
                Console.WriteLine(" ===============");
                j.Verinformacionpersona();
                Console.WriteLine(" ===============");
                n += 1;
            }
            Console.WriteLine("");
            Console.WriteLine(" ===========");
            Console.WriteLine(" MEDICO");
            Console.WriteLine(" ===========");
            Console.WriteLine("");
            e.medico.Verinformacionpersona();
            Console.WriteLine("");
            Console.WriteLine(" ===========");
            Console.WriteLine(" ENTRENADOR");
            Console.WriteLine(" ===========");
            Console.WriteLine("");
            e.entrenador.Verinformacionpersona();
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }


}
