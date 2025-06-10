namespace TP_SalaDeEscape.Models;

public static class SalaDeEscape 
{

public string[] respuestas = new string[6];


static void inicializarGrupo()
{
     respuestas[0] = "178";
     respuestas[1] = "reglas del labo";
     respuestas[2] = "14/08";
     respuestas[3] = "programar";
     respuestas[4] = "";
     respuestas[5] = "";
}
static void comparar (int numeroSala, string respuesta)
{

bool pasa = false;
do
{
    if (respuestas[numeroSala - 1] == respuesta)
{
pasa = true;
}
}while(pasa == false);

}
} 
