using System;
using System.Drawing;


namespace CSharpVariables
{

    class Basics
    {
        static void Main(string[] args)
        {
            /* // hola mundo

             Console.WriteLine("Hello, World!");


             // tipos de datos

             // los tipos de datos son practimente igual a java

             // VARIABLES

             int numero = 10;
             Console.WriteLine(numero);

             string nombre = "Juan";
             Console.WriteLine(nombre);

             double doble = 12.383757339;
             Console.WriteLine(doble);

             float flotante = 12.2f;
             Console.WriteLine(flotante);

             bool myBool = false;
             Console.WriteLine(myBool);

             decimal x = 12.3m;
             Console.WriteLine(x);

             Console.WriteLine($"mi numero es: {numero} y mi valor booleano es: {nombre}");

             // CONSTANTES

             const string miConstante = "esto es una constante";
             Console.WriteLine(miConstante);

             // diccionario de datos

             var miDiccionario = new Dictionary<string, int>
             {
               {"juan", 1},
               {"ana", 2},
               {"mario",3}
             };

             // for

             for (int i = 0; i < 4; i++)
             {
                 Console.Write(i);
                 Console.WriteLine(i);

             } */

            // Type Casting

            /*double num = 12.2;
            int numInt = Convert.ToInt32(num);
            Console.WriteLine(numInt.GetType());

            String n = "@";
            char m = Convert.ToChar(n);
            Console.WriteLine(m.GetType());



            Console.WriteLine("Hola Bienvenid@, Ingresa tu nombre: ");
            String? Nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("cual es tu edad?: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hola " + Nombre + " tu edad es: " + edad); */


            // MATH CLASS

            double a = 12;

            double c = Math.Pow(a, 2);
            Console.WriteLine(c);

            double z = 100;

            double raiz = Math.Sqrt(z);

            Console.WriteLine(raiz);


            // numeros "Ramdom"

            Random random = new Random();

            int numeroR = random.Next(1, 7);

            Console.WriteLine(numeroR);


            // calculo de la hipotenusa

            /*Console.WriteLine("ingrese el valor del cateto A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el valor del cateto B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            double hipotenusa = Math.Sqrt((A * A) + (B * B));

            Console.WriteLine("el valor de la Hipotenusa es: " + hipotenusa); */

            // String methods https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-10.0

            String nombreCompleto = "Juan Diego";

            nombreCompleto = nombreCompleto.ToUpper();
            Console.WriteLine(nombreCompleto);

            // estructuras de control

            // if

            /* Console.WriteLine("ingresa tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("cumples con la mayoria de edad, puede pasar");
            }
            else
            {
                Console.WriteLine("no cumples con la mayoria de edad.");
            } */


            // switch

            /*Console.WriteLine("ingresa un dia de la semana");
            String? dia = Console.ReadLine();

            dia = dia?.ToLower();

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("Hoy es " + dia);
                    break;

                case "martes":
                    Console.WriteLine("Hoy es " + dia);
                    break;

                case "miercoles":
                    Console.WriteLine("Hoy es " + dia);
                    break;

                case "jueves":
                    Console.WriteLine("Hoy es " + dia);
                    break;

                case "viernes":
                    Console.WriteLine("Hoy es " + dia);
                    break;

                case "sabado":
                    Console.WriteLine("Hoy es " + dia);
                    break;

                case "domingo":
                    Console.WriteLine("Hoy es " + dia);
                    break;

                default:
                    Console.WriteLine(dia + " no es un numero de la semana");
                    break;
            } */


            /*Console.WriteLine("ingrese una temperatura: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 18 && temp <= 24)
            {
                Console.WriteLine("esta dentro la temperatua perfecta");
            }
            else if (temp > 24 && temp <= 29)
            {
                Console.WriteLine("la temperatura sigue es aceptable");
            }
            else if (temp > 30)
            {
                Console.WriteLine("ya hace calor");
            }
            else if (temp <= 17 && temp >= 10)
            {
                Console.WriteLine("esta fresco");
            }
            else if (temp < 10)
            {
                Console.WriteLine("hace frio");
            } */


            // bucle while

            /* System.Console.WriteLine("ingresa un numero: ");
             int nume = Convert.ToInt32(Console.ReadLine());

             int limite = 15;

             while(nume<=limite)
             {
                 Console.WriteLine(nume);
                 nume++;
             } */


            // for loop

            /* for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            } */


            /*Console.WriteLine("cuantas filas quieres agregar?: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("cuantas columnas quieres agregar?: ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("que simbolo quieres imprimir?: ");
            string? forma = Console.ReadLine();

            for (int v = 0; v < filas; v++)
            {

                for (int i = 0; i < columnas; i++)
                {
                    Console.Write(forma);
                }

                Console.WriteLine();
            } */


            // piedra, papel o tijera


            /*Random aleatorio = new Random();
            bool jugarOtravez = true;
            string jugador;
            string computadora;
            string respuesta;

            while (jugarOtravez)
            {
                jugador = "";
                computadora = "";
                //respuesta = "";

                while (jugador != "PIEDRA" && jugador != "PAPEL" && jugador != "TIJERAS")
                {
                    Console.WriteLine("Bienvenid@ a piedra papel o tijera!!");
                    Console.WriteLine("elije: ");
                    jugador = Console.ReadLine()!;
                    jugador = jugador.ToUpper();

                }

                switch (aleatorio.Next(1, 4))
                {
                    case 1:
                        computadora = "PIEDRA";
                        break;

                    case 2:
                        computadora = "PAPEL";
                        break;

                    case 3:
                        computadora = "TIJERAS";
                        break;
                }

                Console.WriteLine("elegiste: " + jugador);
                Console.WriteLine("CPU: " + computadora);

                switch (jugador)
                {
                    case "PIEDRA":
                        if (computadora == "PIEDRA")
                        {
                            Console.WriteLine("ES UN EMPATE");
                        }
                        else if (computadora == "PAPEL")
                        {
                            Console.WriteLine("PERDISTE");
                        }
                        else
                        {
                            Console.WriteLine("GANASTE!!!");
                        }
                        break;

                    case "PAPEL":
                        if (computadora == "PIEDRA")
                        {
                            Console.WriteLine("GANASTE!!!");
                        }
                        else if (computadora == "PAPEL")
                        {
                            Console.WriteLine("ES UN EMPATE");
                        }
                        else
                        {
                            Console.WriteLine("PERDISTE");
                        }
                        break;

                    case "TIJERAS":
                        if (computadora == "PIEDRA")
                        {
                            Console.WriteLine("PERDISTE");
                        }
                        else if (computadora == "PAPEL")
                        {
                            Console.WriteLine("GANASTE!!!");
                        }
                        else
                        {
                            Console.WriteLine("ES UN EMPATE");
                        }
                        break;
                }

                Console.WriteLine("quieres jugar otra vez: (S/N): ");
                respuesta = Console.ReadLine()!;
                respuesta = respuesta.ToUpper();

                if (respuesta == "S")
                {
                    jugarOtravez = true;
                }
                else
                {
                    jugarOtravez = false;
                }



            }

            Console.WriteLine("gracias por jugar!!!"); */


            // calculadora basica

            double num1 = 0;
            double num2 = 0;
            double resultado;
            string opcion;
            bool seguir = true;

            while (seguir)
            {
                Console.WriteLine("CALCULADOR ABASICA DE DOS DIGITOS");
                Console.WriteLine("elije una opcion: ");
                Console.WriteLine("Sumar: (1) ");
                Console.WriteLine("Restar: (2) ");
                Console.WriteLine("Multiplicar: (3)");
                Console.WriteLine("Dividir: (4)");
                int operacion;
                operacion = Convert.ToInt32(Console.ReadLine());

                if (operacion != 1 && operacion != 2 && operacion != 3 && operacion != 4)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("solo ingresa opciones disponibles!!!");
                    Console.WriteLine("------------------------------------");
                    
                }
                else
                {
                    switch (operacion)
                    {
                        case 1:
                            Console.WriteLine("elegiste suma: ");
                            Console.WriteLine("ingresa el valor del primer numero: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("ingresa el valor del primer numero: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            resultado = num1 + num2;
                            Console.WriteLine("el resultado de la suma es: " + resultado);
                            break;

                        case 2:
                            Console.WriteLine("elegiste resta: ");
                            Console.WriteLine("ingresa el valor del primer numero: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("ingresa el valor del primer numero: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            resultado = num1 - num2;
                            Console.WriteLine("el resultado de la resta es: " + resultado);
                            break;

                        case 3:
                            Console.WriteLine("elegiste multiplicacion: ");
                            Console.WriteLine("ingresa el valor del primer numero: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("ingresa el valor del primer numero: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            resultado = num1 * num2;
                            Console.WriteLine("el resultado de la multiplicacion es: " + resultado);
                            break;

                        case 4:
                            Console.WriteLine("elegiste Division: ");
                            Console.WriteLine("ingresa el valor del primer numero: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("ingresa el valor del primer numero: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            resultado = num1 / num2;
                            Console.WriteLine("el resultado de la Division es: " + resultado);
                            break;
                    }

                    Console.WriteLine("quieres hacer otra operacion?: (S/N)");
                    opcion = Console.ReadLine()!;
                    opcion = opcion.ToUpper();

                    if (opcion == "S")
                    {
                        seguir = true;
                    }
                    else
                    {
                        seguir = false;
                    }

                }




            }










        }

    }

}

















