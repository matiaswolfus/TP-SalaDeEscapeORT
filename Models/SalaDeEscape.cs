namespace TP_SalaDeEscape;
public class SalaDeEscape
{
    public string[] respuestasSala = new string[6];

    public int salaActual = 1;


        public SalaDeEscape()
        {
             
         respuestasSala[0] = "";
         respuestasSala[1] = "";
         respuestasSala[2] = "";
         respuestasSala[3] = "";
         respuestasSala[4] = "";
         respuestasSala[5] = "";

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
