using System;


namespace CSharpVariables
{

    class Variables
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

            Console.WriteLine($"mi numero es: {numero} y mi valor booleano es: {myBool}");

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

            // estructuras de control

            for(int i=0; i<10; i++)
            {
                Console.WriteLine(i);
            }

        }

    }

}

















