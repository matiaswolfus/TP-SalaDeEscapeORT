using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TP0
{
    internal class Torneo
    {
        List<Robot> robots;
        public Torneo()
        {
            robots = new List<Robot>();

        }

        internal bool agregarRobot(string nombreR)
        {
            

            for(int i = 0; i < robots.Count; i++)
            {
                if (nombreR == robots[i].giveName())
                {
                    return false;
                }
            }
                Robot robotNuevo = new Robot(nombreR);
            
            robots.Add(robotNuevo);
            return true;

        }

        internal void mostrarResultados(string nombre)
        {
            int posiRobot = -1;

            for (int i = 0; i < robots.Count; i++)
            {
                if (robots[i].giveName() == nombre)
                {
                    posiRobot = i;
                }
            }

            mostrarEstadisticas(posiRobot,nombre);
        }

        internal void mostrarEstadisticas(int posiRobot, string nombre)
        {
            int menor;
            List<int> mayorP = new List<int>();

            if (posiRobot == -1)
            {
                Console.WriteLine("Este robot no existe");

            }
            else 
            {
               menor = robots[posiRobot].traerMenor();
                mayorP = robots[posiRobot].posicionMayor();
                Console.WriteLine("el robot " + nombre + ": ");
                Console.WriteLine("puntuacion mas baja: " + menor + "\n rondas con puntuacion mas alta: ");
                for (int i = 0;i < mayorP.Count; i++)
                {
                    Console.Write(mayorP[i] + ", ");
                }

            }



        }
        internal string mejorRobot()
        {
            string nombreMayorP =" ";
            double min = int.MinValue;

            for (int i = 0; i < robots.Count; i++)
            {
                if (robots[i].promedio() > min)
                {
                    nombreMayorP = robots[i].giveName();
                    min = robots[i].promedio();
                }

            }
            return nombreMayorP;

        }
        internal void cargarPuntuacion(string nombre, int puntuacion)
        {
            for (int i = 0; i < robots.Count; i++)
            {
                if (robots[i].giveName() == nombre)
                {
                    robots[i].agregarPuntuacion(puntuacion);
                }

            }

        }
        internal void listarRobots()
        {
            for (int i = 0; i < robots.Count ; i++)
            {
                Console.WriteLine(robots[i].giveName() + ", ");
            }
        }





    }
}