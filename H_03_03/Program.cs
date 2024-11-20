using System;

namespace H_03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int alto; //Creamos la variable del alto del triángulo.
            bool isANumber; //Creamos la variable que comprabará que hayamos introducido un número.

            try //Iniciamos la función try/catch para detectar cualquier error que pueda suceder en el programa.
            {
                do //Iniciamos un bucle 'do...while'
                {
                    Console.Write("Introduzca un alto: "); //Pedimos al usuario que introduzca el alto.
                    isANumber = Int32.TryParse(Console.ReadLine(), out alto); //Comprobamos que el dato introducido sea un número.
                }
                while (!isANumber || alto < 0); //Si el dato no es un número, o es un número negativo, repetimos el bucle.




                for (int i = 1; i <= alto; i++) //Iniciamos el bucle 'for' que contendrá el código para la creación del triángulo.
                {
                    for (int j = 1; j <= alto - i; j++) //Escribimos un espacio en todo el ancho del triángulos, menos el valor actual de 'j'. 
                    {
                        Console.Write(" "); //Carácter a escribir.
                    }
                    for (int k = 1; k <= i; k++) //Escribimos un asterisco tras los espacios.
                    {
                        Console.Write("*"); //Carácter a escribir.

                    }


                    Console.WriteLine(""); //Salto de línea.
                }
            }
            catch (Exception error) //Nombramos la variable de la excepción.
            {
                Console.Write("Error code {0}", error); //En caso de que haya un error, escribimos en consola el código de dicho error.
            }
        }
    }
}
