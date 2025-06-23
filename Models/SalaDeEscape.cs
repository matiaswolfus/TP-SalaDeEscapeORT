namespace TP_SalaDeEscape;
public class SalaDeEscape
{
    public string[] respuestasSala = new string[6];

    public int salaActual = 1;


        public SalaDeEscape()
        {
             //"que todas las respuestas que lleguen pasarlas a minusculas y sacar espacios"
         respuestasSala[0] = "178";// en decimal 178 = 10110010 en binario
         respuestasSala[1] = "reglasdellabo"; // por las dudas aclarar que es labo y no laboratorio 
         respuestasSala[2] = "respuestaaa"; //poner algo del cumple de dami asman
         respuestasSala[3] = "cidi"; //los pasajes de avión van a ser 4 y los destinos van a formar la palabra
         respuestasSala[4] = "programar"; // noc como pero es esa la palabra
         respuestasSala[5] = "respuestaaaaaa"; // no vimos todavia un codigo, que lo haga gasti o zoe

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
