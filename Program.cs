namespace CHIVO_WALLET
{
    using System.Drawing;
    using System.Threading;

    //using System.Drawing;
    //Te da acceso a clases relacionadas con gráficos, colores, imágenes, etc., como Bitmap, Color, Graphics. (solo lo use para el color del texto)

    //using System.Threading;
    //Te permite trabajar con hilos(Thread), tareas de sincronización(Mutex, Monitor, etc.), Mira para que me entiendas yo lo use para pausar una parte del codigo
    //pero es mucho mas complejo, es como si tuvieras la gema del tiempo (Avergers) y tienes el poder de adelantar el recorrido de tu codigo!. 

    internal class Program
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Bienvenido veras que he dejado a lo largo que estuve programando, comentarios.
            //Como primer comentario el codigo que esta arriba UTF8, es para que sean compatibles la mayoria de iconos ASCII que tengo abajo

            //Console.WriteLine("● ○ ◉ ◯ ■ □ ▪ ▫ ▲ △ ▼ ▽ ▶ ◀ ◆ ◇ ◈ ⬤ ▣ ▤ ↑ ↓ → ← ↔ ⇨ ✦ ★ ☆ ✧ ☰ ✎ ✔ ✖ • ═ ║ █ ▓ ▒ ░ ▌ ▐");
            //Console.ReadKey();
            //Es mas deje comentado lo de arriba, ya que con eso hacia pruebas de que simbolos funcionan y cuales no!.

            //************************************************************** VARIABLES GLOBALES

            double menu_usuario = 0;
            double submenu_usuario = 0;

            double numero_usuario_uno = 0;
            double numero_usuario_dos = 0;
            //double resultado = 0;

            //string dato_usuario = "";

            bool activador_menu = true;
            bool activador_submenu = true;

            //int[] numeros;
            //La matriz tal vez, el día de mañana lo habilite para crear un sistema de historial.


            //************************************************************** ANIMACIÓN E INICIO DEL PROGRAMA
            Console.Clear();
            color_fondo(0);
            color_texto(2);
            Console.WriteLine("By Prof. Urquilla");

            color_fondo(1);
            color_texto(15);
            Logo_chivo_wallet();

            color_texto(7);
            Console.WriteLine("Bitcoin es una moneda digital (No física) que sólo existe en la cadena de bloques o blockchain que la soporta.");
            Console.WriteLine("Como moneda, puede servir para todo lo que se utiliza cualquier otra moneda \nrespaldada por un Estado como lo puede ser el euro o el dólar.");
            Console.WriteLine("\n");


            color_texto(15);
            Console.Write("CARGANDO");
            for (int i = 0; i < 70; i++)
            {
                Console.Write(".");
                Thread.Sleep(50);//Sirve para hacer una pausa en el programa, pero es necesario primero declarar unas directivas, que estan muy arriba del codigo!.
                                 //using System.Drawing;
                                 //using System.Threading;

            }

            Console.WriteLine("");
            Console.WriteLine("");
            color_texto(10);
            Console.Write("[+]");

            color_texto(15);
            Console.Write(" Carga completada. ");

            Console.WriteLine("");
            color_texto(10);
            Console.Write("[+]");

            color_texto(15);
            Console.Write(" Preciona cualquier tecla para continuar. ");
            color_fondo(0);
            Console.ReadKey();


            while (activador_menu)
            {

                //MENU DEL PROGRAMA

                Console.Clear();
                color_fondo(0);
                color_texto(15);

                Logo_chivo_wallet();
                linea_decoracion();

                color_texto(11);
                Console.Write("[/]");
                color_texto(7);
                Console.WriteLine(" [CHIVOWALLET] →→ [MENU]");




                color_texto(10);
                Console.Write("[+]");

                color_texto(15);
                Console.WriteLine(" Bienvenido al sistema de calculos de chivo wallet, Donde podra hacer calculos básicos.\n");

                Console.WriteLine("" +
                    "╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\r\n" +
                    "║                                                    MENU                                                      ║\r\n" +
                    "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                //****************************** OPCION 01
                color_texto(12);
                Console.Write("  01.  ");

                color_texto(15);
                Console.Write("[SUMA]             ");

                color_texto(7);
                Console.Write("(Combinar dos o mas números para obtener un total ");

                color_texto(10);
                Console.Write("A+B");

                color_texto(7);
                Console.Write(")\n");

                //****************************** OPCION 02

                color_texto(12);
                Console.Write("  02.  ");

                color_texto(15);
                Console.Write("[RESTA]            ");

                color_texto(7);
                Console.Write("(Encontrar la diferencia entre dos números ");

                color_texto(10);
                Console.Write("A-B");

                color_texto(7);
                Console.Write(")\n");

                //****************************** OPCION 03

                color_texto(12);
                Console.Write("  03.  ");

                color_texto(15);
                Console.Write("[MULTIPLICACIÓN]   ");

                color_texto(7);
                Console.Write("(Repetir un número varias veces según el otro ");

                color_texto(10);
                Console.Write("A*B");

                color_texto(7);
                Console.Write(")\n");

                //****************************** OPCION 04

                color_texto(12);
                Console.Write("  04.  ");

                color_texto(15);
                Console.Write("[DIVISIÓN]         ");

                color_texto(7);
                Console.Write("(Repartir un número en partes iguales ");

                color_texto(10);
                Console.Write("A/B");

                color_texto(7);
                Console.Write(")\n");

                //****************************** OPCION 05

                color_texto(12);
                Console.Write("  05.  ");

                color_texto(15);
                Console.Write("[ELEVACIÓN]        ");

                color_texto(7);
                Console.Write("(Multiplicar un número por sí mismo varias veces ");

                color_texto(10);
                Console.Write("A^B");

                color_texto(7);
                Console.Write(")\n");

                //****************************** OPCION 06

                color_texto(12);
                Console.Write("  06.  ");

                color_texto(15);
                Console.Write("[CONVERSIÓN]       ");

                color_texto(7);
                Console.Write("(Conversión de dólar a bitcoin y viceversa");

                color_texto(10);
                Console.Write(" $ <-> ₿");

                color_texto(7);
                Console.Write(") ");

                color_texto(12);
                Console.WriteLine("            [↓] Inactivo");



                //****************************** OPCION 05

                color_texto(12);
                Console.Write("  07.  ");

                color_texto(15);
                Console.Write("[SALIR]            ");

                color_texto(7);
                Console.Write("(Cierra el programa ");
                Console.Write(")\n");
                Console.WriteLine("\n");
                color_texto(6);

                //****************************** INDICACIONES

                Console.Write("[!]");
                Console.Write(" Selecione la opción del tramite que desea utilizar, ");
                color_texto(14);
                Console.WriteLine("Ejemplo: 1, 2, 3, 01, 02, 03");

                //****************************** PIDIENDO DATOS AL USUARIO

                linea_decoracion();
                menu_usuario = convertidor_numero();

                //****************************** EVALUANDO LA OPCION ELEGIDA POR EL USUARIO

                Console.Clear();
                color_texto(15);

                Logo_chivo_wallet();

                linea_decoracion();
                color_texto(11);
                Console.Write("[/]");
                color_texto(7);

                switch (menu_usuario)
                {

                    case 1:

                        activador_submenu = true;
                        Console.Write(" [CHIVOWALLET] →→ [MENU] →→ [01 SUMA]");

                        while (activador_submenu)
                        {

                            color_texto(6);
                            Console.WriteLine("");
                            Console.Write("[!]");
                            Console.Write(" Se pedirán 2 número pueden ser enteros o decimales, Para completar la formula: ");
                            color_texto(10);
                            Console.Write("A + B = C \n");
                            Console.WriteLine("");

                            Console.WriteLine("[*] Para la variable (A)");
                            numero_usuario_uno = convertidor_numero();
                            Console.WriteLine("[*] Para la variable (B)");
                            numero_usuario_dos = convertidor_numero();
                            Console.WriteLine("");


                            formulas_matematicas("SUMA", numero_usuario_uno, numero_usuario_dos);

                            Console.WriteLine("");
                            color_texto(10);
                            Console.Write("[+]");

                            color_texto(15);
                            Console.Write(" Selecione una opción por favor: ");

                            //****************************** OPCION 01

                            color_texto(12);
                            Console.Write("01.");

                            color_texto(15);
                            Console.Write(" [REGRESAR MENU PRINCIPAL] /");

                            //****************************** OPCION 02

                            color_texto(12);
                            Console.Write(" 02.");

                            color_texto(15);
                            Console.WriteLine(" [VOLVER HACER OTRA SUMA]");

                            Console.WriteLine("");

                            submenu_usuario = convertidor_numero();

                            color_texto(15);
                            linea_decoracion();

                            if (submenu_usuario == 1)
                            {
                                activador_submenu = false;
                            }
                        }

                        break;

                    case 2:
                        activador_submenu = true;
                        Console.Write(" [CHIVOWALLET] →→ [MENU] →→ [02 RESTA]");

                        while (activador_submenu)
                        {

                            color_texto(6);
                            Console.WriteLine("");
                            Console.Write("[!]");
                            Console.Write(" Se pedirán 2 número pueden ser enteros o decimales, Para completar la formula: ");
                            color_texto(10);
                            Console.Write("A - B = C \n");
                            Console.WriteLine("");

                            Console.WriteLine("[*] Para la variable (A)");
                            numero_usuario_uno = convertidor_numero();
                            Console.WriteLine("[*] Para la variable (B)");
                            numero_usuario_dos = convertidor_numero();
                            Console.WriteLine("");


                            formulas_matematicas("RESTA", numero_usuario_uno, numero_usuario_dos);

                            Console.WriteLine("");
                            color_texto(10);
                            Console.Write("[+]");

                            color_texto(15);
                            Console.Write(" Selecione una opción por favor: ");

                            //****************************** OPCION 01

                            color_texto(12);
                            Console.Write("01.");

                            color_texto(15);
                            Console.Write(" [REGRESAR MENU PRINCIPAL] /");

                            //****************************** OPCION 02

                            color_texto(12);
                            Console.Write(" 02.");

                            color_texto(15);
                            Console.WriteLine(" [VOLVER HACER OTRA SUMA]");

                            Console.WriteLine("");

                            submenu_usuario = convertidor_numero();

                            color_texto(15);
                            linea_decoracion();

                            if (submenu_usuario == 1)
                            {
                                activador_submenu = false;
                            }
                        }
                        break;

                    case 3:
                        activador_submenu = true;
                        Console.Write(" [CHIVOWALLET] →→ [MENU] →→ [03 MULTIPLICACIÓN]");

                        while (activador_submenu)
                        {

                            color_texto(6);
                            Console.WriteLine("");
                            Console.Write("[!]");
                            Console.Write(" Se pedirán 2 número pueden ser enteros o decimales, Para completar la formula: ");
                            color_texto(10);
                            Console.Write("A x B = C \n");
                            Console.WriteLine("");

                            Console.WriteLine("[*] Para la variable (A)");
                            numero_usuario_uno = convertidor_numero();
                            Console.WriteLine("[*] Para la variable (B)");
                            numero_usuario_dos = convertidor_numero();
                            Console.WriteLine("");


                            formulas_matematicas("MULTI", numero_usuario_uno, numero_usuario_dos);

                            Console.WriteLine("");
                            color_texto(10);
                            Console.Write("[+]");

                            color_texto(15);
                            Console.Write(" Selecione una opción por favor: ");

                            //****************************** OPCION 01

                            color_texto(12);
                            Console.Write("01.");

                            color_texto(15);
                            Console.Write(" [REGRESAR MENU PRINCIPAL] /");

                            //****************************** OPCION 02

                            color_texto(12);
                            Console.Write(" 02.");

                            color_texto(15);
                            Console.WriteLine(" [VOLVER HACER OTRA MULTIPLICACIÓN]");

                            Console.WriteLine("");

                            submenu_usuario = convertidor_numero();

                            color_texto(15);
                            linea_decoracion();

                            if (submenu_usuario == 1)
                            {
                                activador_submenu = false;
                            }
                        }
                        break;

                    case 4:
                        activador_submenu = true;
                        Console.Write(" [CHIVOWALLET] →→ [MENU] →→ [03 DIVISIÓN]");

                        while (activador_submenu)
                        {

                            color_texto(6);
                            Console.WriteLine("");
                            Console.Write("[!]");
                            Console.Write(" Se pedirán 2 número pueden ser enteros o decimales, Para completar la formula: ");
                            color_texto(10);
                            Console.Write("A ÷ B = C \n");
                            Console.WriteLine("");

                            Console.WriteLine("[*] Para la variable (A)");
                            numero_usuario_uno = convertidor_numero();
                            Console.WriteLine("[*] Para la variable (B)");
                            numero_usuario_dos = convertidor_numero();
                            Console.WriteLine("");

                            if ((numero_usuario_uno == 0) || (numero_usuario_dos == 0))
                            {
                                //Como sabe 0, no puede dividirse por 0
                                errores(05);
                            }
                            else
                            {
                                formulas_matematicas("DIVI", numero_usuario_uno, numero_usuario_dos);

                            }

                            Console.WriteLine("");
                            color_texto(10);
                            Console.Write("[+]");

                            color_texto(15);
                            Console.Write(" Selecione una opción por favor: ");

                            //****************************** OPCION 01

                            color_texto(12);
                            Console.Write("01.");

                            color_texto(15);
                            Console.Write(" [REGRESAR MENU PRINCIPAL] /");

                            //****************************** OPCION 02

                            color_texto(12);
                            Console.Write(" 02.");

                            color_texto(15);
                            Console.WriteLine(" [VOLVER HACER OTRA DIVISIÓN]");

                            Console.WriteLine("");

                            submenu_usuario = convertidor_numero();

                            color_texto(15);
                            linea_decoracion();

                            if (submenu_usuario == 1)
                            {
                                activador_submenu = false;
                            }
                        }
                        break;


                    case 5:
                        activador_submenu = true;
                        Console.Write(" [CHIVOWALLET] →→ [MENU] →→ [05 ELEVACIÓN]");

                        while (activador_submenu)
                        {

                            color_texto(6);
                            Console.WriteLine("");
                            Console.Write("[!]");
                            Console.Write(" Se pedirán 2 número pueden ser enteros o decimales, Para completar la formula: ");
                            color_texto(10);
                            Console.Write("A ^ B = C \n");
                            Console.WriteLine("");

                            Console.WriteLine("[*] Para la variable (A)");
                            numero_usuario_uno = convertidor_numero();
                            Console.WriteLine("[*] Para la variable (B)");
                            numero_usuario_dos = convertidor_numero();
                            Console.WriteLine("");


                            formulas_matematicas("ELEVAR", numero_usuario_uno, numero_usuario_dos);

                            Console.WriteLine("");
                            color_texto(10);
                            Console.Write("[+]");

                            color_texto(15);
                            Console.Write(" Selecione una opción por favor: ");

                            //****************************** OPCION 01

                            color_texto(12);
                            Console.Write("01.");

                            color_texto(15);
                            Console.Write(" [REGRESAR MENU PRINCIPAL] /");

                            //****************************** OPCION 02

                            color_texto(12);
                            Console.Write(" 02.");

                            color_texto(15);
                            Console.WriteLine(" [VOLVER HACER OTRA ELEVACIÓN]");

                            Console.WriteLine("");

                            submenu_usuario = convertidor_numero();

                            color_texto(15);
                            linea_decoracion();

                            if (submenu_usuario == 1)
                            {
                                activador_submenu = false;
                            }
                        }
                        break;

                    case 6:
                        activador_submenu = true;
                        Console.Write(" [CHIVOWALLET] →→ [MENU] →→ [06 CONVERTIDOR]");


                        Console.WriteLine("");
                        errores(8);

                        Console.WriteLine("");
                        color_texto(10);
                        Console.Write("[+]");

                        color_texto(15);
                        Console.Write(" Preciona cualquier tecla para continuar. ");
                        Console.ReadKey();


                        break;

                    case 7:
                        Console.WriteLine("");
                        color_texto(10);
                        Console.Write("[+]");

                        color_texto(15);
                        Console.Write(" Preciona cualquier tecla para salir del programa. ");
                        //Console.ReadKey();
                        activador_menu = false;
                        break;

                    case 20202020:
                        ColorfulAnimation();
                        break;

                    default:
                        errores(4);

                        Console.WriteLine("");
                        color_texto(10);
                        Console.Write("[+]");

                        color_texto(15);
                        Console.Write(" Preciona cualquier tecla para continuar. ");
                        Console.ReadKey();
                        break;
                }

            }

            Console.ReadKey();

        }


        //FUNCIONES DECORATIVAS
        //*****************************************
        static void Logo_chivo_wallet()
        {
            //Te preguntaras como hice esto: 
            //https://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20
            //Utilizaba este sitio web para poder hacer decoraciones.

            Console.WriteLine("\r\n" +
                "         ██████╗██╗  ██╗██╗██╗   ██╗ ██████╗     ██╗    ██╗ █████╗ ██╗     ██╗     ███████╗████████╗\r\n" +
                "        ██╔════╝██║  ██║██║██║   ██║██╔═══██╗    ██║    ██║██╔══██╗██║     ██║     ██╔════╝╚══██╔══╝\r\n" +
                "        ██║     ███████║██║██║   ██║██║   ██║    ██║ █╗ ██║███████║██║     ██║     █████╗     ██║   \r\n" +
                "        ██║     ██╔══██║██║╚██╗ ██╔╝██║   ██║    ██║███╗██║██╔══██║██║     ██║     ██╔══╝     ██║   \r\n" +
                "        ╚██████╗██║  ██║██║ ╚████╔╝ ╚██████╔╝    ╚███╔███╔╝██║  ██║███████╗███████╗███████╗   ██║   \r\n" +
                "         ╚═════╝╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═════╝      ╚══╝╚══╝ ╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝   ╚═╝.EXE v1.3\r\n");
        }

        static void linea_decoracion()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }
        static void color_fondo(int color)
        {
            switch (color)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 7:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 12:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }

        }

        static void color_texto(int color)
        {
            switch (color)
            {

                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 14:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }

        }

        static void formulas_matematicas(string operacion, double A, double B)
        {
            double resultado = 0;

            switch (operacion)
            {
                //***************************************************
                //Lo mejor de todo esto que nada mas trabaje con el case "SUMA" y despues solo copie y pegue e hice pequeños cambios!.
                //Suma
                case "SUMA":
                    resultado = A + B;

                    color_texto(10);
                    Console.WriteLine("     FORMULA  |  RESULTADO  ");
                    Console.WriteLine("       A      |     " + A + "     ");
                    Console.WriteLine("       B   +  |     " + B + "   + ");
                    Console.WriteLine("   ---------  |  ---------");
                    Console.WriteLine("   Resultado  |     " + resultado + "     ");

                    break;

                case "RESTA":
                    resultado = A - B;

                    color_texto(10);
                    Console.WriteLine("     FORMULA  |  RESULTADO  ");
                    Console.WriteLine("       A      |     " + A + "     ");
                    Console.WriteLine("       B   -  |     " + B + "   - ");
                    Console.WriteLine("   ---------  |  ---------");
                    Console.WriteLine("   Resultado  |     " + resultado + "     ");

                    break;

                case "MULTI":
                    resultado = A * B;

                    color_texto(10);
                    Console.WriteLine("     FORMULA  |  RESULTADO  ");
                    Console.WriteLine("       A      |     " + A + "     ");
                    Console.WriteLine("       B   x  |     " + B + "   x ");
                    Console.WriteLine("   ---------  |  ---------");
                    Console.WriteLine("   Resultado  |     " + resultado + "     ");

                    break;

                case "DIVI":
                    resultado = Math.Round(A / B, 2);
                    //Te preguntas para que ese Math.Round, lo que es Redondear el número, entonces tenia el problema de que me al dividir 50/4,5 me salia 11,11111111
                    //con es Match.Round(50 / 45, 2) es que me haga la división y luego me redonde dejandome solo 2 numeros despues del punto decimal.
                    // De igual si tienes dudas pues preguntame, No te cuesta acercarte en recreo!. 

                    //Es mas ya me empute se me acaba de caer el café!.
                    //Perdon, Curiosamente los comentarios de programadores nunca faltan en los programas o juegos, es mas hasta en tu juego favorito ha de existir un comentarios
                    // así como este. ¿Loco no?, jajaja!

                    color_texto(10);
                    Console.WriteLine("     FORMULA  |  RESULTADO  ");
                    Console.WriteLine("       A      |     " + A + "     ");
                    Console.WriteLine("       B   ÷  |     " + B + "   ÷ ");
                    Console.WriteLine("   ---------  |  ---------");
                    Console.WriteLine("   Resultado  |     " + resultado + "     ");

                    break;

                case "ELEVAR":
                    resultado = Math.Pow(A, B);

                    //Se acuerdan que hicimos algo así para elevar pero con un FOR, pues esta la forma mas facil
                    //sin embargo la idea de hacer eso en una sintaxis FOR era para poder manejar el bucle FOR.
                    //Match.Pow(,) Elevar un número!. 

                    color_texto(10);
                    Console.WriteLine("     FORMULA  |  RESULTADO  ");
                    Console.WriteLine("       A      |     " + A + "     ");
                    Console.WriteLine("       B   ^  |     " + B + "  ^  ");
                    Console.WriteLine("   ---------  |  ---------");
                    Console.WriteLine("   Resultado  |     " + resultado + "     ");

                    break;

            }
        }

        static void errores(int codigo_error)
        {
            switch (codigo_error)
            {
                case 01:
                    color_texto(12);
                    Console.WriteLine("[░] ERROR-CHIVO-001 (Se esperaba un número, pero se ingresó texto o símbolos)");

                    break;
                case 05:
                    color_texto(12);
                    Console.WriteLine("[░] ERROR-CHIVO-005 (Se intentó dividir entre cero, No permitido matemáticamente)");

                    break;
                //Por que arriba esta 5 y abajo 4, facil me dio hueva copiar y pegar para ordenar el codigo, mientras funciones no hay problema.

                case 04:
                    color_texto(12);
                    Console.WriteLine("[░] ERROR-CHIVO-004 (Número no reconocido, Se ingresó una opción no válida en el menú)");

                    break;

                case 08:
                    color_texto(9);
                    Console.WriteLine("[░] ERROR-CHIVO-008 (Función Bloqueada). \n\n" +
                        "¡Chivo Wallet v1.4 está por llegar!\r\n" +
                        "La nueva versión viene con mejoras que seguro vas a disfrutar...\r\n" +
                        "Todo está cocinándose a fuego lento, como unos buenos frijoles.\r\n\r\n" +
                        "Bueno ya fuera del ROL, Espero les sirva este programa y su codigo fuente para mejorar en programación ");

                    Console.WriteLine("Aquí un Easter Egg: 20202020");
                    Console.WriteLine("");
                    Console.WriteLine("By Prof. Jonnathan Urquilla");

                    break;

                    // **********************************
                    // Lo que tengo aquí es una tabla donde se crearo codigos de errores inventados, pero basados
                    // como el famoso 404, pero con tematica de chivo wallet

                    //CHIVO - 001   EntradaNoNumerica Se esperaba un número, pero se ingresó texto o símbolos.
                    //CHIVO - 002   ValorFueraDeRango Número fuera del rango permitido para la operación.
                    //CHIVO - 003   Entrada Vacia El usuario no ingresó ningún valor.
                    //CHIVO - 004   Número No Reconocido Se ingresó una opción no válida en el menú.
                    //CHIVO - 005   Division Por Cero Se intentó dividir entre cero. (No permitido matemáticamente).
                    //CHIVO - 006   ConfirmacionInvalida Se esperaba un “sí” o “no”, pero la entrada fue distinta.
                    //CHIVO - 007   AccesoDenegado El usuario no tiene permisos suficientes para esta acción.
                    //CHIVO - 008   Actualizar Hola gr
            }
        }

        //FUNCIONES VALIDATIVAS
        //*****************************************

        static double convertidor_numero()
        {
            double numero_convertido;
            bool bucle_datos_usuario = true;

            while (bucle_datos_usuario)
            {
                color_texto(10);
                Console.Write("[■]");

                color_texto(15);
                Console.Write(" DIGITE UN NÚMERO POR FAVOR: ");
                color_texto(10);

                if (double.TryParse(Console.ReadLine(), out numero_convertido))
                {
                    return numero_convertido;
                }
                else
                {
                    color_texto(12);
                    Console.WriteLine("[░] ERROR-CHIVO-001 (Se esperaba un número, pero se ingresó texto o símbolos)");
                }
            }

            return 0;
        }


        //FUNCIONES QUE NOS LAS CREE YO Y LAS COPIE DE INTERNET
        //CREDITOS: 
        // How to make you console app look cool - Michał Białecki Blog. (2018, mayo 24). Michał Białecki Blog.
        // https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
        //*****************************************
        static void ColorfulAnimation()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Clear();

                    // steam
                    Console.Write("       . . . . o o o o o o", Color.LightGray);
                    for (int s = 0; s < j / 2; s++)
                    {
                        Console.Write(" o", Color.LightGray);
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);
                    Console.WriteLine(margin + "                _____      o", Color.LightGray);
                    Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.", Color.DeepSkyBlue);
                    Console.WriteLine(margin + "      [________]_|__|________)< ", Color.DeepSkyBlue);
                    Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_", Color.Blue);
                    Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);

                    Thread.Sleep(200);
                }
            }
        }
    }
}
