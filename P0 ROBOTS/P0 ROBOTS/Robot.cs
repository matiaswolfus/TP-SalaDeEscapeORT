using System;
using System.Collections.Generic;
using System.Text;

namespace P0_ROBOTS
{
    internal class Robot
    {
        string nombre;
        List<int> puntuaciones;
        public Robot(string nombre)
        {
            this.nombre = nombre;
            puntuaciones = new List<int>();
        }


        public string devolverNombre()
        {
            return nombre;
        }

        private int traerMenor()
        {

            int menorP = int.MaxValue;
            for (int i = 0; i < puntuaciones.Count; i++)
            {
                if (puntuaciones[i] < menorP)
                {
                    menorP = puntuaciones[i];
                }

            }
            return menorP;
        }

        private List<int> posicionMayor()

        {
            List<int> mayorP = new List<int>();
            int max = int.MaxValue;
            for (int i = 1; i <= puntuaciones.Count; i++)
            {
                if (puntuaciones[i - 1] >= max)
                {
                    max = puntuaciones[i - 1];
                    mayorP.Add(i);
                }
            }

            return mayorP;

        }

        private double promedio()
        {
            double promedio;
            promedio = calcularPromedio();
            return promedio;
        }

        private double calcularPromedio()
        {
            int numeroPuntos = 0;
            double promedio = 0;
            for (int i = 0; i < puntuaciones.Count; i++)
            {
                numeroPuntos = numeroPuntos + puntuaciones[i];
            }
            promedio = numeroPuntos / puntuaciones.Count;
            return promedio;
        }
        private void agregarPuntuacion(int punto)
        {
            puntuaciones.Add(punto);
        } 


    }
}
