namespace TP03_MusicStore.Models;
public static class Catalogo
{
    public static  Dictionary<int, Disco> discos = new Dictionary<int, Disco>();

   

    public static void CrearDiscos()
    {
        // Disco 111 - MILO J
        Artista miloJ = new Artista("MILO J");
        Genero generoTrap = new Genero("Trap / Rap");
        Productor productorBiza = new Productor("Bizarrap");
        Disco disco111 = new Disco( 1,"111", "111MILOJ.jpg", generoTrap, miloJ, productorBiza);
        disco111.temas.Add(new Tema("TU MANTA"));
        disco111.temas.Add(new Tema("CARENCIAS DE CORDURA (ft. Yami Safdie)"));
        disco111.temas.Add(new Tema("M.A.I"));
        disco111.temas.Add(new Tema("DESEO PERDER (INTERLUDIO)"));
        disco111.temas.Add(new Tema("SINCERA TE"));
        disco111.temas.Add(new Tema("TE FUI A SEGUIR (ft. Yahritza y su Esencia)"));
        disco111.temas.Add(new Tema("UNA BALA (ft. Peso Pluma)"));
        disco111.temas.Add(new Tema("ALUMBRE (ft. Nicki Nicole)"));
        disco111.temas.Add(new Tema("A1RE"));
        discos.Add(1,disco111);

        // Disco Alma - Nicki Nicole
        Artista nicki = new Artista("Nicki Nicole");
        Genero generoPopUrbano = new Genero("Pop Urbano");
        Productor productorTatool = new Productor("Tatool");
        Disco discoAlma = new Disco(6, "Alma", "ALMANICKI.jpg", generoPopUrbano, nicki, productorTatool);
        discoAlma.temas.Add(new Tema("Ya No"));
        discoAlma.temas.Add(new Tema("Dispara"));
        discoAlma.temas.Add(new Tema("Qué Le Pasa Conmigo?"));
        discoAlma.temas.Add(new Tema("Se va 1 llegan 2"));
        discoAlma.temas.Add(new Tema("8AM"));
        discoAlma.temas.Add(new Tema("Tienes Mi Alma"));
        discoAlma.temas.Add(new Tema("Llámame"));
        discoAlma.temas.Add(new Tema("Caen las Estrellas"));
        discos.Add(6, discoAlma);

        // Disco Infame - Babasónicos
        Artista babasonicos = new Artista("Babasónicos");
        Genero generoRock = new Genero("Rock Alternativo");
        Productor productorGustavo = new Productor("Gustavo Iglesias");
        Disco discoInfame = new Disco(2, "Infame", "INFAMEBABASONICOS.jpg", generoRock, babasonicos, productorGustavo);
        discoInfame.temas.Add(new Tema("Yegua"));
        discoInfame.temas.Add(new Tema("Putita"));
        discoInfame.temas.Add(new Tema("Irresponsables"));
        discoInfame.temas.Add(new Tema("El Colmo"));
        discoInfame.temas.Add(new Tema("Risa"));
        discoInfame.temas.Add(new Tema("Camarín"));
        discoInfame.temas.Add(new Tema("Sin mi Diablo"));
        discoInfame.temas.Add(new Tema("La Fox"));
        discos.Add(2, discoInfame);

        // Disco MP3 - Emilia Mernes
        Artista emilia = new Artista("Emilia Mernes");
        Genero generoPop = new Genero("Pop");
        Productor productorBigOne = new Productor("Big One");
        Disco discoMP3 = new Disco(3, "MP3", "MP3EMILIA.jpg", generoPop, emilia, productorBigOne);
         discoMP3.temas.Add(new Tema("Jagger.mp3"));
        discoMP3.temas.Add(new Tema("No_Se_Ve.mp3"));
        discoMP3.temas.Add(new Tema("GTA.mp3"));
        discoMP3.temas.Add(new Tema("La_Original.mp3"));
        discoMP3.temas.Add(new Tema("Exclusive.mp3"));
        discoMP3.temas.Add(new Tema("Underground.mp3"));
        discoMP3.temas.Add(new Tema("24_HS.mp3"));
        discoMP3.temas.Add(new Tema("Intoxicao.mp3"));
        discos.Add(3, discoMP3);

        // Disco Starboy - The Weeknd
        Artista theWeeknd = new Artista("The Weeknd");
        Genero generoRnB = new Genero("R&B / Pop");
        Productor productorDaftPunk = new Productor("Daft Punk");
        Disco discoStarboy = new Disco(4, "Starboy", "STARBOYTHEWEEKND.jpg", generoRnB, theWeeknd, productorDaftPunk);
        discoStarboy.temas.Add(new Tema("Starboy"));
        discoStarboy.temas.Add(new Tema("Party Monster"));
        discoStarboy.temas.Add(new Tema("False Alarm"));
        discoStarboy.temas.Add(new Tema("Reminder"));
        discoStarboy.temas.Add(new Tema("Rockin'"));
        discoStarboy.temas.Add(new Tema("Secrets"));
        discoStarboy.temas.Add(new Tema("I Feel It Coming"));
        discoStarboy.temas.Add(new Tema("Die For You"));
        discos.Add(4, discoStarboy);

        // Disco AM - Arctic Monkeys
        Artista arcticMonkeys = new Artista("Arctic Monkeys");
        Genero generoRockAlt = new Genero("Rock Alternativo");
        Productor productorJamesFord = new Productor("James Ford");
        Disco discoAM = new Disco(5, "AM", "AMARCTIC.jpg ", generoRockAlt, arcticMonkeys, productorJamesFord);
        discoAM.temas.Add(new Tema("Do I Wanna Know?"));
        discoAM.temas.Add(new Tema("R U Mine?"));
        discoAM.temas.Add(new Tema("One For The Road"));
        discoAM.temas.Add(new Tema("Arabella"));
        discoAM.temas.Add(new Tema("I Want It All"));
        discoAM.temas.Add(new Tema("Why'd You Only Call Me When You're High?"));
        discoAM.temas.Add(new Tema("Snap Out Of It"));
        discoAM.temas.Add(new Tema("Knee Socks"));
        discos.Add(5, discoAM);


        Artista babasonicos2 = new Artista("Babasónicos");
        Genero generoRockArg = new Genero("Rock Alternativo");
        Productor productorJessico = new Productor("Andrew Weiss");
        Disco discoJessico = new Disco(7,"JESSICO", "JESSICOBABASONICOS.jpg", generoRockArg, babasonicos2, productorJessico);
        discoJessico.temas.Add(new Tema("Los Calientes"));
        discoJessico.temas.Add(new Tema("Deléctrico"));
        discoJessico.temas.Add(new Tema("Fizz"));
        discoJessico.temas.Add(new Tema("Tóxica"));
        discoJessico.temas.Add(new Tema("Y Qué?"));
        discoJessico.temas.Add(new Tema("La Fox"));
        discos.Add(7, discoJessico);

// Disco HIT ME HARD AND SOFT - Billie Eilish
        Artista billie = new Artista("Billie Eilish");
        Genero generoAltPop = new Genero("Alt Pop");
        Productor productorFinneas = new Productor("Finneas");
        Disco discoHitMe = new Disco(8, "HIT ME HARD AND SOFT", "HITMEBILLIE.jpg", generoAltPop, billie, productorFinneas);
        discoHitMe.temas.Add(new Tema("SKINNY"));
        discoHitMe.temas.Add(new Tema("LUNCH"));
        discoHitMe.temas.Add(new Tema("CHIHIRO"));
        discoHitMe.temas.Add(new Tema("BIRDS OF A FEATHER"));
        discoHitMe.temas.Add(new Tema("THE GREATEST"));
        discos.Add(8, discoHitMe);

// Disco AMALA - Doja Cat
        Artista doja = new Artista("Doja Cat");
        Genero generoHipHop = new Genero("Hip Hop / Pop");
        Productor productorYeti = new Productor("Yeti Beats");
        Disco discoAmala = new Disco( 9, "AMALA", "AMALADOJA.jpg", generoHipHop, doja, productorYeti);
        discoAmala.temas.Add(new Tema("Go To Town"));
        discoAmala.temas.Add(new Tema("Juicy"));
        discoAmala.temas.Add(new Tema("Candy"));
        discoAmala.temas.Add(new Tema("Roll With Us"));
        discoAmala.temas.Add(new Tema("Game"));
        discos.Add(9, discoAmala);

// Disco HOMERUN - Paulo Londra
        Artista paulo = new Artista("Paulo Londra");
        Genero generoTrap2 = new Genero("Trap / Urbano");
        Productor productorOvy = new Productor("Ovy on the Drums");
        Disco discoHomeRun = new Disco(10, "HOMERUN", "HOMERUMPAULO.jpg", generoTrap2, paulo, productorOvy);
        discoHomeRun.temas.Add(new Tema("Adán y Eva"));
        discoHomeRun.temas.Add(new Tema("Tal Vez"));
        discoHomeRun.temas.Add(new Tema("Forever Alone"));
        discoHomeRun.temas.Add(new Tema("Nena Maldición"));
        discoHomeRun.temas.Add(new Tema("Condenado Para El Millón"));
        discos.Add(10, discoHomeRun);
    }
}