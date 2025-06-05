using System;
using System.Collections.Generic;
using System.Text;

namespace TP0
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


        public string giveName()
        {
            return nombre;
        }

        public int traerMenor()
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

        public List<int> posicionMayor()

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

        public double promedio()
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
        internal void agregarPuntuacion(int punto)
        {
            puntuaciones.Add(punto);
        }
       

    }
}