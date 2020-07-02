using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace examen_jcgubbins
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("BIENVENIDO, INGRESE EL NUMERO DE LO QUE DESEA HACER: ");
            Console.WriteLine(" 1. CREAR EQUIPO");
            Console.WriteLine(" 2. SALIR");
            string opcion5 = "";
            while (opcion5 != "2")
            {
                opcion5 = Console.ReadLine();
                switch (opcion5)
                {
                    case "1":
                        List<Jugador> jugadorescreados = new List<Jugador>();
                        Console.WriteLine("PROCEDAMOS A CREAR UN EQUIPO");
                        Console.WriteLine("============================================");
                        Thread.Sleep(2000);
                        string nombrequipo = "";
                        string tipodeequipo = "";
                        Console.WriteLine("INGRESE EL NOMBRE DEL EQUIPO");
                        nombrequipo = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("INGRESE EL NUMERO DEL TIPO DE EQUIPO QUE DESEA CREAR: ");
                        Console.WriteLine(" 1. SELECCION NACIONAL");
                        Console.WriteLine(" 2. EQUIPO DE LIGA");
                        string opcion3;
                        opcion3 = Console.ReadLine();
                        switch (opcion3)
                        {
                            case "1":
                                tipodeequipo = "Seleccion nacional";
                                break;
                            case "2":
                                tipodeequipo = "Equipo de liga";
                                break;
                            default:
                                Console.WriteLine("INGRESE UNA OPCION VALIDA");
                                Thread.Sleep(1000);

                                break;
                        }
                        Console.WriteLine("VAMOS A CREAR A LOS JUGADORES");
                        int n = 0;
                        while (n < 15)
                        {
                            string nombrejugador = "";
                            int edadj = 0;
                            string nacionj = "";
                            string sueldoj = "";
                            int puntosataque = 0;
                            int puntosdefensa = 0;
                            int numerocamiseta = 0;
                            Console.WriteLine("Ingrese el nombre del jugador " + (n + 1));
                            nombrejugador = Console.ReadLine();
                            string valorvalido = "no";
                            while (valorvalido == "no")
                            {
                                Console.WriteLine("Ingrese la edad del jugador ");
                                try
                                {
                                    edadj = int.Parse(Console.ReadLine());
                                    valorvalido = "si";

                                }
                                catch
                                {
                                    Console.WriteLine("INGRESE UN VALOR VALIDO");
                                    Thread.Sleep(2000);
                                }
                            }
                            Console.WriteLine("Ingrese la nacion del jugador " + (n + 1));
                            nacionj = Console.ReadLine();
                            Console.WriteLine("Ingrese el sueldo del jugador " + (n + 1));
                            sueldoj = Console.ReadLine();

                            string valorvalido2 = "no";
                            while (valorvalido2 == "no")
                            {
                                Console.WriteLine("Ingrese los puntos de ataque del jugador");
                                try
                                {
                                    puntosataque = int.Parse(Console.ReadLine());
                                    valorvalido2 = "si";

                                }
                                catch
                                {
                                    Console.WriteLine("INGRESE UN VALOR VALIDO");
                                    Thread.Sleep(2000);
                                }
                            }
                            string valorvalido3 = "no";
                            while (valorvalido3 == "no")
                            {
                                Console.WriteLine("Ingrese los puntos de defensa del jugador");
                                try
                                {
                                    puntosdefensa = int.Parse(Console.ReadLine());
                                    valorvalido3 = "si";

                                }
                                catch
                                {
                                    Console.WriteLine("INGRESE UN VALOR VALIDO");
                                    Thread.Sleep(2000);
                                }
                            }
                            string valorvalido4 = "no";
                            while (valorvalido4 == "no")
                            {
                                Console.WriteLine("Ingrese el numero de camiseta del jugador");
                                try
                                {
                                    numerocamiseta = int.Parse(Console.ReadLine());
                                    valorvalido4 = "si";

                                }
                                catch
                                {
                                    Console.WriteLine("INGRESE UN VALOR VALIDO");
                                    Thread.Sleep(2000);
                                }
                            }
                            Jugador j = new Jugador(nombrejugador, edadj, nacionj, sueldoj, puntosataque, puntosdefensa, numerocamiseta);
                            jugadorescreados.Add(j);
                            Console.WriteLine("JUGADOR CREADO EXISTOSAMENTE");
                            Thread.Sleep(1000);
                            n += 1;
                            Console.Clear();







                        }
                        Thread.Sleep(2000);
                        Console.WriteLine("VAMOS A CREAR AL ENTRENADOR DEL EQUIPO");
                        Thread.Sleep(1000);
                        string nombree = "";
                        int edade = 0;
                        string nacione = "";
                        string sueldoe = "";
                        int puntostactica = 0;
                        Console.WriteLine(" Ingrese en nombre del entrenador");
                        nombree = Console.ReadLine();
                        string valorvalido5 = "no";
                        while (valorvalido5 == "no")
                        {
                            Console.WriteLine("Ingrese la edad del entrenador ");
                            try
                            {
                                edade = int.Parse(Console.ReadLine());
                                valorvalido5 = "si";

                            }
                            catch
                            {
                                Console.WriteLine("INGRESE UN VALOR VALIDO");
                                Thread.Sleep(2000);
                            }
                        }
                        Console.WriteLine("Ingrese la nacion del entrenador");
                        nacione = Console.ReadLine();
                        Console.WriteLine("Ingrese el sueldo del entrenador");
                        sueldoe = Console.ReadLine();
                        string valorvalido6 = "no";
                        while (valorvalido6 == "no")
                        {
                            Console.WriteLine("Ingrese los puntos de tactica del entrenador ");
                            try
                            {
                                puntostactica = int.Parse(Console.ReadLine());
                                valorvalido6 = "si";

                            }
                            catch
                            {
                                Console.WriteLine("INGRESE UN VALOR VALIDO");
                                Thread.Sleep(2000);
                            }
                        }
                        Entrenador en = new Entrenador(nombree, edade, nacione, sueldoe, puntostactica);
                        Console.WriteLine("ENTRENADOR CREADO EXITOSAMENTE");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("VAMOS A CREAR AL MEDICO DEL EQUIPO");
                        Thread.Sleep(1000);
                        string nombrem = "";
                        int edadm = 0;
                        string nacionm = "";
                        string sueldom = "";
                        int puntosexp = 0;
                        Console.WriteLine(" Ingrese en nombre del medico");
                        nombrem = Console.ReadLine();
                        string valorvalido7 = "no";
                        while (valorvalido7 == "no")
                        {
                            Console.WriteLine("Ingrese la edad del medico ");
                            try
                            {
                                edadm = int.Parse(Console.ReadLine());
                                valorvalido7 = "si";

                            }
                            catch
                            {
                                Console.WriteLine("INGRESE UN VALOR VALIDO");
                                Thread.Sleep(2000);
                            }
                        }
                        Console.WriteLine("Ingrese la nacion del medico");
                        nacionm = Console.ReadLine();
                        Console.WriteLine("Ingrese el sueldo del medico");
                        sueldom = Console.ReadLine();
                        string valorvalido8 = "no";
                        while (valorvalido8 == "no")
                        {
                            Console.WriteLine("Ingrese los puntos de experiencia del medico ");
                            try
                            {
                                puntosexp = int.Parse(Console.ReadLine());
                                valorvalido8 = "si";

                            }
                            catch
                            {
                                Console.WriteLine("INGRESE UN VALOR VALIDO");
                                Thread.Sleep(2000);
                            }
                        }
                        Medico m = new Medico(nombrem, edadm, nacionm, sueldom, puntosexp);
                        Console.WriteLine("MEDICO CREADO EXITOSAMENTE");
                        Thread.Sleep(2000);
                        Console.Clear();


                        Equipo eq = new Equipo(nombrequipo, tipodeequipo, jugadorescreados, en, m);
                        Console.WriteLine("LISTO!!! EQUIPO CREADO EXITOSAMENTE");
                        Thread.Sleep(2000);
                        if (tipodeequipo == "Seleccion nacional")
                        {
                            Console.WriteLine("HAS MARCADO QUE TU EQUIPO PERTENECE A UNA SELECCION NACIONAL, VAMOS A VERIFICARLO...");
                            Thread.Sleep(1000);
                            eq.Corroborarnacionalidad(jugadorescreados);
                        }
                        break;
                    case "2":
                        Console.WriteLine("CERRANDO EL PROGRAMA");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("INGRESE UNA OPCION VALIDA");
                        Thread.Sleep(1000);
                        break;

                }











            }
        }
    }
}
