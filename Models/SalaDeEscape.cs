namespace TP_SalaDeEscape;
public class TP_SalaDeEscape
{
    public string[] respuestasSala = new string[6];


    public void llenarRespuestas()
     {
        respuestasSala[0] = "";
        respuestasSala[1] = "";
        respuestasSala[2] = "";
        respuestasSala[3] = "";
        respuestasSala[4] = "";
        respuestasSala[5] = "";
     }



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
        }

        return aux;
     }
}
