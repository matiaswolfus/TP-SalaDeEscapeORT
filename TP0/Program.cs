using System;
using System.Collections.Generic;
using System.Net;

namespace TP0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Torneo torneoN = new Torneo();
            do
            {
                mostrarMenu();
                opcion = seleccionarOp();
                seguir();
                switch (opcion)
                {
                    case 1:
                       
                        tocarTecla();
                        break;
                    case 2:
                        agregarPuntuacion(torneoN);
                        break;
                    case 3:
                        string nombre;
                        List<int> puntuaciones = new List<int>();
                        nombre = ingresarString("ingrese el nombre del robot al cual quiere agregar una puntuacion");
                        torneoN.mostrarResultados(nombre);
                        tocarTecla();
                        break;
                    case 4:
                        torneoN.mejorRobot();
                        tocarTecla();
                        break;
                    case 5:
                        torneoN.listarRobots();
                        tocarTecla();
                        break;
                    case 6:
                    break;

                    case 7:
                    break;
                
                }

            } while (opcion != 8);

        }

        private static void mostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Menu de opciones: ");
            Console.WriteLine("1.Agregar Evento");
            Console.WriteLine("2.Eliminar Evento ");
            Console.WriteLine("3.Modificar Fecha y Duracion del Evento  ");
            Console.WriteLine("4.Comprarar Fechas Entre Dos eventos");
            Console.WriteLine("5. Mover un Evento del Calendario");
            Console.WriteLine("6. MOstrar el Proximo Evento");
            Console.WriteLine ("7.Listar Todos Los Eventos");
            console.WriteLine ("8. Salir ");
        }
        static int seleccionarOp()
        {
            int opcion;
            do
            {
                opcion = ingresarInt("ingrese el numero de opcion que desea:");
                if (!(opcion >= 1 && opcion <= 8))
                {
                    Console.WriteLine("ERROR, REINGRESAR");
                }
            }
            while (!(opcion >= 1 && opcion <= 8));
            return opcion;
        }
       
        static int ingresarInt(string msj)
        {
            int aux;
            Console.WriteLine(msj);
            aux = int.Parse(Console.ReadLine());
            return aux;
        }
        static void seguir()
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
        static string ingresarString(string msj)
        {
            string aux;
            Console.WriteLine(msj);
            aux = Console.ReadLine();
            return aux;
        }
        static void tocarTecla()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ingrese cualquier cosa para seguir");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadKey();
            Console.Clear();
        }
    }
}
