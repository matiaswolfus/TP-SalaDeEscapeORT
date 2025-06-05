namespace TP03_MusicStore.Models;

public class Disco
{
    public int num;
    public List<Tema> temas;


    public string nombre;
    public string foto;

    public Genero generoDisco;
    public Artista artistaDisco;
    public Productor productorDisco;

    public Disco( int num, string nombre, string foto, Genero genero, Artista artista, Productor productor)
    {
        this.num = num;
        this.temas = new List<Tema>();
        this.nombre = nombre;
        this.foto = foto;
        generoDisco = genero;
        artistaDisco = artista;
        productorDisco = productor;
    }


    
}
