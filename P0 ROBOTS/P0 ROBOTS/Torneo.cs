using System;
using System.Collections.Generic;
using System.Text;

namespace P0_ROBOTS
{
    internal class Torneo
    {
        List<Robot> robots;
        public Torneo() 
        
        {
             robots = new List<Robot>();

        }

        private void agregarRobot (Robot robo)
        {
          robots.Add(robo);
        }

        private void mostrarResultados (string nombre)
        {
            int posiRobot = -1;
            
            for (int i = 0; i < robots.Count; i++)
            {
                if (robots[i].devolverNombre() == nombre) 
                { 
                posiRobot = i;
                }
            }

            mostrarEstadisticas (posiRobot);
        }

        private void mostrarEstadisticas (int posiRobot) 
        {

        if (posiRobot == -1)
            {
                Console.WriteLine("Este robot no existe");

            } else if 
            {
                Console.WriteLine("");
            }
                

        
        }

       

       



    }
}
