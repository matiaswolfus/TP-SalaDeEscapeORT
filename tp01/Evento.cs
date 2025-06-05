using System;
using System.Collections.Generic;
using System.Text;

namespace tp01
{
    internal class Evento
    {
         public string nombreEvento {get; private set;}  
        public DateTime fechaHora {get; private set;}  
        public int duracion {get ; private set;}
     public string tema{get; private set;}  
       public string ubicacion {get; private set;}  
            public Evento(string nombreEvento ,DateTime fechaHora ,int duracion,string tema,string ubicacion)
            {
                 this.nombreEvento = nombreEvento;
                 this.fechaHora = fechaHora;
                 this.fechaHora = fechaHora;
                 this.duracion = duracion;
                 this.tema = tema;
                 this.ubicacion = ubicacion;
            }
          internal DateTime devolverFechaHora ()
          {
               return fechaHora;

          }
           internal void modificarFechaHora (DateTime nuevaFecha)
           {
            fechaHora = nuevaFecha;
           }

           internal void modificarDuracion (int Nuevaduracion)
           {
            duracion = Nuevaduracion;

           }

           internal void moverFecha (int desplazaDias)
           {
            fechaHora = fechaHora.AddDays(desplazaDias); 
            
           }
    }
}