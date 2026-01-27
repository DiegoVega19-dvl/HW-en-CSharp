using System;
using System.Drawing;


namespace CSharpVariables
{

    class Basics
    {
        static void Main(string[] args)
        {
            // hola mundo

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

            }

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





              



        }

    }

}

















