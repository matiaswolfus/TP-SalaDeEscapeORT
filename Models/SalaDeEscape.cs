namespace TP_SalaDeEscape;
public class SalaDeEscape
{
    public string[] respuestasSala = new string[6];


    public int salaActual = 1;


     public int intentosFallidos = 0;
    public DateTime? castigoHasta = null;
    public bool EnCastigo => castigoHasta != null && DateTime.Now < castigoHasta;






        public SalaDeEscape()
        {
            
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


    public bool JugarPorSala (int numeroSala, string respuesta) 
    { 
        return compararRespuesta(numeroSala, respuesta);
        
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


