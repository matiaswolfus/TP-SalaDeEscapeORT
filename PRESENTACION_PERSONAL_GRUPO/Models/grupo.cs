namespace PRESENTACION_PERSONAL_GRUPO.Models;


static class grupo 
{

public static Dictionary<int, integrante> integrantes{get; private set;}= new Dictionary<int, integrante>();

public static void inicializarGrupo()
{
    
    integrantes.Clear();
    datoPersonal datoPersonalW = new datoPersonal("Matias","Wolfus", new DateTime (2008,12,10), "matias wolfus.jpg");
    datosInteres datosW = new datosInteres("jugar y ver al futbol, jugar a los jueguitos y estar con amigos", "me encanta GAME OF THRONES y SUITS", "Lucho", "la mejor materia de la historia es programacion con leo kristal pero me gusta matematica ");
    
     datoFamiliar datosPapaW = new datoFamiliar("Pablo", "Wolfus", "Padre", "tiene 46 años, le gusta el futbol y los perros");
    datoFamiliar datosmamaW = new datoFamiliar("Betiana", "Mirensky", "Madre", "tiene 47 años, le gusta cocinar y los perros");
    datoFamiliar datoshermanaW = new datoFamiliar("Julieta", "Wolfus", "hermana", "tiene 19 años, le gusta dar pehula y estar con la familia");

     List<datoFamiliar> datosFamiliaWolfus = new List<datoFamiliar>();
    datosFamiliaWolfus.Add(datosPapaW);
    datosFamiliaWolfus.Add(datosmamaW);
    datosFamiliaWolfus.Add(datoshermanaW);

    integrante integranteW = new integrante (49194355, datoPersonalW, datosW, datosFamiliaWolfus);

    datoPersonal datoPersonalZ = new datoPersonal("Zoe","Acquistapace", new DateTime (2008,12,19), "zoeAcquistapace.jpg");
    datosInteres datosZ = new datosInteres("Juntarme con mis amigas y salir a pasear con mi abuela", "Mi serie favorita es Gilmore girls", "Entre mis mejores amigos estan Giuliana, Naomi, Isabella, Maximo, Matias", "Mi materia favorita es programacion ya que tenemos uno de los mejores profesores :)");

    datoFamiliar datosPapaZ = new datoFamiliar("Gabriel", "Acquistapace", "Padre", "Trabaja en el ambito de la informatica y tiene 49 años");
    datoFamiliar datosmamaZ = new datoFamiliar("Soledad", "Guerrero", "Madre", "Es odontologa y le gustan mucho las plantas");
    datoFamiliar datoshermanaZ = new datoFamiliar("Elena", "Acquistapace", "hermana", "Estudia en ORT en segundo año y le gusta jugar al roblox");

    List<datoFamiliar> datosFamiliaAcquistapace = new List<datoFamiliar>();
    datosFamiliaAcquistapace.Add(datosPapaZ);
    datosFamiliaAcquistapace.Add(datosmamaZ);
    datosFamiliaAcquistapace.Add(datoshermanaZ);

    integrante integranteZ = new integrante (49091323, datoPersonalZ, datosZ,datosFamiliaAcquistapace);

    integrantes.Add(49091323,integranteZ);
    integrantes.Add (49194355,integranteW);
}
}       