using System;
using System.Collections.Generic;
using System.Text;

namespace tp01
{
internal class gestorEventos 
{

    Dictionary<string, Evento> dicEventos;
    public gestorEventos ()
    {
        dicEventos = new Dictionary<string, Evento>();
    }
    
    internal void agregarEvento (string orador, Evento evento) 
    {        
     if (dicEventos.ContainsKey(orador))
     {
        Console.WriteLine("Este orador ya tiene un evento");

     } else 
     {
         dicEventos.Add(orador,evento);
     }
    }
        
    internal void eliminarEventos (string orador)
    {
        if (dicEventos.ContainsKey(orador))
        {
            dicEventos.Remove(orador);

        } else 
        {
            Console.WriteLine ("NO existe este orador");
        }

    }

    internal void modificarEvento (string orador, DateTime nuevaFechaHora, int Nuevaduracion) 
    {
        if (dicEventos.ContainsKey(orador))
        {
          Evento nuevoEvento = dicEventos[orador]; 
        nuevoEvento.modificarFechaHora(nuevaFechaHora);
        nuevoEvento.modificarDuracion(Nuevaduracion);
        dicEventos[orador]= nuevoEvento;
        }
    }

    internal int compararFecha (string orador1, string orador2)
    {
        int diferencia = -1;
        if (dicEventos.ContainsKey(orador1))
        {
            if (dicEventos.ContainsKey(orador2))
            {
                Evento nuevoEvento1 = dicEventos[orador1];
                Evento nuevoEvento2 = dicEventos[orador2];
                diferencia = (nuevoEvento1.fechaHora - nuevoEvento2.fechaHora).Days;              
            }
        } else
         {
            Console.WriteLine ("uno de los oradores no esta en el sistema registrado");

        }
        return diferencia;
    }

    internal void moverEvento (string orador, int dias)
    {
        if (dicEventos.ContainsKey(orador))
        {
            Evento nuevoEvento = dicEventos[orador];
            nuevoEvento.moverFecha(dias);
            dicEventos[orador] = nuevoEvento;
        }
    }

    internal Evento obtenerProximoEvento ()
    {
        DateTime max = DateTime.MaxValue;
        Evento eventoProximo = null;
        
        foreach(Evento item in dicEventos.Values)
        {
            if (item.fechaHora < max  )
            {
                max = item.fechaHora;
                eventoProximo  = item;
            }            
        }
        return eventoProximo;
    }


}




}