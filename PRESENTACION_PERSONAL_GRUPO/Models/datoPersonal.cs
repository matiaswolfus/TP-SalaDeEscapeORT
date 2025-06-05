namespace PRESENTACION_PERSONAL_GRUPO.Models;

public class datoPersonal
{
public string nombre { get; private set; }
public string apellido{ get; private set;}
public DateTime fechaNacimiento { get; private set; }
public string foto {get; private set;}

public datoPersonal(string nombre, string apellido, DateTime fechaNacimiento, string foto)
{
    this.nombre = nombre;
    this.apellido = apellido;
    this.fechaNacimiento = fechaNacimiento;
    this.foto = foto;
}
internal int ObtenerEdad()
{
    DateTime hoy = DateTime.Today;
    int edad;
    edad =  hoy.Year - this.fechaNacimiento.Year;
    return edad;
}

}
