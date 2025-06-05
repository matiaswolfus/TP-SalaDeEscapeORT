namespace tp01
{
public  class GestorEntrevista
{
     Dictionary<int, Entrevista> dicEntrevista;

    public GestorEntrevista ()
    {
        dicEntrevista = new Dictionary<int, Entrevista>();
    }

    internal bool agregarEntrevista (int dni, Entrevista entrevista) 
    {      
        bool validar = true;  
     if (dicEntrevista.ContainsKey(dni))
     {
       validar = false;
     } else 
     {
         dicEntrevista.Add(dni,entrevista);
     }

     return validar;
    }

    internal bool eliminarEntrevista (int dni)
    {
        bool validar = true;
        if (dicEntrevista.ContainsKey(dni))
        {
            dicEntrevista.Remove(dni);

        } else 
        {
            validar = false;
        }

        return validar;

    }

     internal void modificarEntrevista (int dni, DateTime nuevaFechaHora, int Nuevaduracion) 
    {
        if (dicEntrevista.ContainsKey(dni))
        {
          Entrevista nuevaEntrevista = dicEntrevista[dni]; 
        nuevaEntrevista.modificarFechaHora(nuevaFechaHora);
        nuevaEntrevista.modificarDuracion(Nuevaduracion);
        dicEntrevista[dni]= nuevaEntrevista;
        }
    }

      internal int compararEntrevistas (int dni1, int dni2)
    {
        int diferencia = -1;
        if (dicEntrevista.ContainsKey(dni1))
        {
            if (dicEntrevista.ContainsKey(dni2))
            {
                Entrevista nuevaEntrevista1 = dicEntrevista[dni1];
                Entrevista nuevaEntrevista2 = dicEntrevista[dni2];
                diferencia = (nuevaEntrevista1.fechaHora - nuevaEntrevista2.fechaHora).Days;              
            }
        } 
        return diferencia;
    }

     internal void moverEntrevistas (int dni, int dias)
    {
        if (dicEntrevista.ContainsKey(dni))
        {
            Entrevista nuevaEntrevista = dicEntrevista[dni];
            nuevaEntrevista.moverFecha(dias);
            dicEntrevista[dni] = nuevaEntrevista;
        }


    }

    internal Entrevista obtenerProximaEntrevista ()
    {
        DateTime max = DateTime.MaxValue;
        Entrevista proximaEntrevista = null;
        
        foreach(Entrevista item in dicEntrevista.Values)
        {
            if (item.fechaHora < max  )
            {
                max = item.fechaHora;
                proximaEntrevista  = item;
            }            
        }
        return proximaEntrevista;
    }
    internal void listarEntrevista()
    {
        foreach(var Entrevista in dicEntrevista)
        {
            Console.WriteLine(Entrevista.Value.candidato);
            Console.WriteLine(Entrevista.Value.fechaHora);
            Console.WriteLine(Entrevista.Value.duracion);
            Console.WriteLine(Entrevista.Value.puesto);
            Console.WriteLine(Entrevista.Value.entrevistador);
        }

    }

}
}