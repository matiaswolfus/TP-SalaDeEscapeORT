using System;
using System.Collections.Generic;
using System.Text;

namespace tp01
{
internal class Entrevista
{
   public string candidato {get; private set;}  
   public  DateTime fechaHora {get; private set;}  
   public int duracion {get; private set;}  
   public string puesto {get; private set;}  
   public string entrevistador {get; private set;}  

    public Entrevista (string candidato, DateTime fechaHora, int duracion, string puesto, string entrevistador) 
    {
        this.candidato = candidato;
        this.fechaHora = fechaHora;
        this.duracion = duracion;
        this.puesto = puesto;
        this.entrevistador = entrevistador;
    }


  internal void modificarFechaHora (DateTime nuevaFecha)
    {
            fechaHora = nuevaFecha;
     }

    internal void modificarDuracion (int duracionNueva) 
    {
        duracion = duracionNueva;

    }

     internal void moverFecha (int desplazaDias)
      {
            fechaHora = fechaHora.AddDays(desplazaDias); 
      }   


    // DateTime fechaHora;
//Console.Write("Ingrese una fecha y hora (ejemplo: 24/03/2025 14:30): ");

//string entrada = Console.ReadLine();

//if (DateTime.TryParse(entrada, out fechaHora))
//{
  //  Console.WriteLine($"La fecha ingresada es: {fechaHora}");
//}
//else
//{
  //  Console.WriteLine("Formato incorrecto. Intente de nuevo.");
//}       

}
}