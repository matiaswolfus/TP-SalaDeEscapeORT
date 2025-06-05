namespace tp01;
    internal class Program
    {
        static GestorEntrevista gestor = new GestorEntrevista();

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
                       agregarEntrevista();
                        tocarTecla();
                        break;
                    case 2:
                       eliminarEntrevista();
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
                        mostrarProximaEntrevista();
                        tocarTecla();
                        break;
                    case 6:
                     tocarTecla();
                    break;
                
                }

            } while (opcion != 7);

        }

        static void mostrarProximaEntrevista()
        {
            Entrevista entrevista;

            entrevista = gestor.obtenerProximaEntrevista();
            Console.WriteLine("La proxima entrevista es " + entrevista);

        }
        static void compararEntreDos ()
        {

            int dni;
            Console.WriteLine("Ingrese el dni del candidato");
            dni = int.Parse(Console.ReadLine());

            int diasMover;
            Console.WriteLine("Ingrese la nueva duracion");
            diasMover= int.Parse(Console.ReadLine());

            gestor.moverEntrevistas(dni,diasMover);

        }
        private static void mostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Menu de opciones: ");
            Console.WriteLine("1.Agregar Entrevista");
            Console.WriteLine("2.Eliminar Entrevista ");
            Console.WriteLine("3.Modificar Fecha y Duracion de la entrevista  ");
            Console.WriteLine("4.Comprarar Fechas Entre Dos entrevistas");
            Console.WriteLine("5. Mover entrevista del Calendario");
            Console.WriteLine("6. Mostrar el Proxima Entrevista");
            Console.WriteLine ("7.Listar Todas Las Entrevistas");
            Console.WriteLine ("8. Salir ");
        }

        static void  ModificarFechaYDuracion()
        {
            int dni;
            Console.WriteLine("Ingrese el nombre del dni");
            dni = int.Parse(Console.ReadLine());

            int duracion;
            Console.WriteLine("Ingrese la nueva duracion");
            duracion= int.Parse(Console.ReadLine());

            DateTime nuevaFecha;
            Console.WriteLine("Agregar la nueva fecha");
            nuevaFecha= DateTime.Parse(Console.ReadLine());

            gestor.modificarEntrevista(dni,nuevaFecha,duracion);
        }
        static void eliminarEntrevista()
        {
            int dni;
            Console.WriteLine("Ingrese el nombre del dni");
            dni = int.Parse(Console.ReadLine());
            gestor.eliminarEntrevista(dni);

        } 

        static void pedirNombredni()
        {
            int dni;
            Console.WriteLine("Ingrese el nombre del dni");
            dni = int.Parse(Console.ReadLine());
        }
        static void agregarEntrevista()
        {
            int dni;
            Entrevista entrevista;
            Console.WriteLine("Ingrese el nombre del dni");
            dni = int.Parse(Console.ReadLine());
           entrevista = crearEntrevista();
           gestor.agregarEntrevista(dni,entrevista);
        }

        static Entrevista crearEntrevista ()
        {
       Console.WriteLine ("Agrega el nombre de la entrevista");
         string nombreEntrevista = Console.ReadLine();  

        Console.WriteLine ("Agregar la fecha ");
         DateTime fechaHora = DateTime.Parse (Console.ReadLine()); 

        Console.WriteLine ("Agregar la duracion");
         int duracion = int.Parse(Console.ReadLine()); 

        Console.WriteLine ("Agrega el tema");      
         string tema = Console.ReadLine();

        Console.WriteLine ("Agregar Ubicacion");
          string ubicacion = Console.ReadLine() ;

        Entrevista entrevista = new Entrevista (nombreEntrevista,fechaHora,duracion,tema,ubicacion);
        return entrevista;

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

