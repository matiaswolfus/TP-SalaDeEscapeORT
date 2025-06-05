namespace PRESENTACION_PERSONAL_GRUPO.Models;

public class integrante 
{
public int DNI { get; private set; }
public datoPersonal datosPersonales { get; private set; }
public List<datoFamiliar> datosFamiliares { get; private set; }
public datosInteres datosIntereses { get; private set; }


public integrante (int DNI, datoPersonal datosPersonal,datosInteres datosIntereses, List<datoFamiliar> datosFamiliares) 
{
    this.DNI = DNI;
    this.datosPersonales = datosPersonal;
    this.datosIntereses = datosIntereses;
    this.datosFamiliares = datosFamiliares;
    
}

}