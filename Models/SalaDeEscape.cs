namespace TP_SalaDeEscape;
public class SalaDeEscape
{
    public string[] respuestasSala = new string[6];

    public int salaActual = 1;


        public SalaDeEscape()
        {
             
         respuestasSala[0] = "respuesta";
         respuestasSala[1] = "respuestaa";
         respuestasSala[2] = "respuestaaa";
         respuestasSala[3] = "respuestaaaa";
         respuestasSala[4] = "respuestaaaaa";
         respuestasSala[5] = "respuestaaaaaa";

        }
        
    public DateTime StartTime { get; set; }
    public TimeSpan Duration { get; set; } = TimeSpan.FromMinutes(10);

    public bool IsTimeUp()
    {
        return DateTime.Now > StartTime + Duration;
    }

    public TimeSpan TimeLeft()
    {
        var endTime = StartTime + Duration;
        return endTime > DateTime.Now ? endTime - DateTime.Now : TimeSpan.Zero;
    }

   // hacer que vaya tirando respuestas, si es que esta mal lo hace repetir el proceso, si esta bien sigue
    public void JugarPorSala (int numeroSala, string respuesta) 
    {
        bool pasoLaSala = false;
        do
        {  
           pasoLaSala = compararRespuesta(numeroSala,respuesta);

        } while (pasoLaSala == false);
        
    }

     public bool compararRespuesta (int numeroSala, string respuesta) 
     {
        bool aux = false;
        if (respuestasSala[numeroSala - 1] == respuesta) 
        {
            aux = true;
            salaActual++;
        }
        return aux;
     }
}
