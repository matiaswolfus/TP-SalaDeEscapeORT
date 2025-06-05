namespace PRESENTACION_PERSONAL_GRUPO.Models;

public class datoFamiliar 
{
public string nombre { get; private set; }
public string apellido{ get; private set; }
public string parentesco{ get; private set; }
public string descripción{ get; private set; }

public datoFamiliar (string nombre, string apellido,string parentesco, string descripción ) 
{
    this.nombre= nombre;
    this.apellido= apellido;
    this.parentesco= parentesco;
    this.descripción = descripción;
}

}