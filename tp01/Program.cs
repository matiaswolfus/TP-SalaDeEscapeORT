namespace tp01;
    internal class Program
    {
        static gestorEventos gestor = new gestorEventos();
        static void Main(string[] args)
        {
           
            int opcion = 0;
            do
            {
                mostrarMenu();
                opcion = seleccionarOp();
                seguir();
                switch (opcion)
                {
                    case 1:
                       AgregarEvento();
                        tocarTecla();
                        break;
                    case 2:
                       eliminarEvento();
                        tocarTecla();
                        break;
                    case 3:
                       ModificarFechaYDuracion();
                        tocarTecla();
                        break;
                    case 4:
                       compararEntreDos();
                        tocarTecla();
                        break;
                    case 5:
                        mostrarProximoEvento();
                        tocarTecla();
                        break;
                    case 6:
                     tocarTecla();
                    break;
                
                }

            } while (opcion != 7);

        }

        static void mostrarProximoEvento()
        {
            Evento evento;

            evento = gestor.obtenerProximoEvento();
            Console.WriteLine("El proximo evento es " + evento);

        }
        static void compararEntreDos ()
        {
            string orador;
            Console.WriteLine("Ingrese el nombre del orador");
            orador = Console.ReadLine();

            int diasMover;
            Console.WriteLine("Ingrese la nueva duracion");
            diasMover= int.Parse(Console.ReadLine());

            gestor.moverEvento (orador,diasMover);


        }
        private static void mostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Menu de opciones: ");
            Console.WriteLine("1.Agregar Evento");
            Console.WriteLine("2.Eliminar Evento ");
            Console.WriteLine("3.Modificar Fecha y Duracion del Evento  ");
            Console.WriteLine("4.Comprarar Fechas Entre Dos eventos");
            Console.WriteLine("5. Mover un Evento del Calendario");
            Console.WriteLine("6. MOstrar el Proximo Evento");
            Console.WriteLine ("7.Listar Todos Los Eventos");
            Console.WriteLine ("8. Salir ");
        }

        static void  ModificarFechaYDuracion()
        {
            string orador;
            Console.WriteLine("Ingrese el nombre del orador");
            orador = Console.ReadLine();

            int duracion;
            Console.WriteLine("Ingrese la nueva duracion");
            duracion= int.Parse(Console.ReadLine());

            DateTime nuevaFecha;
            Console.WriteLine("Agregar la nueva fecha");
            nuevaFecha= DateTime.Parse(Console.ReadLine());

            gestor.modificarEvento(orador,nuevaFecha,duracion);
        }
        static void eliminarEvento()
        {
            string orador;
            Console.WriteLine("Ingrese el nombre del orador");
            orador = Console.ReadLine();
            gestor.eliminarEventos(orador);

        }

        static void pedirNombreOrador()
        {
            string orador;
            Console.WriteLine("Ingrese el nombre del orador");
            orador = Console.ReadLine();
        }
        static void AgregarEvento()
        {
            string orador;
            Evento evento;
            Console.WriteLine("Ingrese el nombre del orador");
            orador = Console.ReadLine();
           evento = crearEvento();
           gestor.agregarEvento(orador,evento);
        }

        static Evento crearEvento ()
        {
       Console.WriteLine ("Agrega el nombre del evento");
         string nombreEvento = Console.ReadLine();  

        Console.WriteLine ("Agregar la fecha ");
         DateTime fechaHora = DateTime.Parse (Console.ReadLine()); 

        Console.WriteLine ("Agregar la duracion");
         int duracion = int.Parse (Console.ReadLine()); 

        Console.WriteLine ("Agrega el tema");      
         string tema = Console.ReadLine();

        Console.WriteLine ("Agregar Ubicacion");
          string ubicacion = Console.ReadLine() ;

        Evento evento = new Evento (nombreEvento,fechaHora,duracion,tema,ubicacion);
        return evento;

        }
        static int seleccionarOp()
        {
            int opcion;
            do
            {
                opcion = ingresarInt("ingrese el numero de opcion que desea:");
                if (!(opcion >= 1 && opcion <= 7))
                {
                    Console.WriteLine("ERROR, REINGRESAR");
                }
            }
            while (!(opcion >= 1 && opcion <= 7));
            return opcion;
        }
       
        static int ingresarInt(string msj)
        {
            int aux;
            Console.WriteLine(msj);
            aux = int.Parse(Console.ReadLine());
            return aux;
        }
        static void seguir()
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
        static string ingresarString(string msj)
        {
            string aux;
            Console.WriteLine(msj);
            aux = Console.ReadLine();
            return aux;
        }
        static void tocarTecla()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ingrese cualquier cosa para seguir");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadKey();
            Console.Clear();
        }
    }
