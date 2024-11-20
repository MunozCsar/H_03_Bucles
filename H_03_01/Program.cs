using System;

namespace H_03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho, alto; //Creamos las variables del ancho y alto del triángulo.
            bool isANumber; //Creamos la variable que comprabará que hayamos introducido un número.

            try //Iniciamos la función try/catch para detectar cualquier error que pueda suceder en el programa.
            {
                do //Iniciamos un bucle 'do...while'
                {
                    Console.Write("Introduzca un alto: "); //Pedimos al usuario que introduzca el alto.
                    isANumber = Int32.TryParse(Console.ReadLine(), out alto); //Comprobamos que el dato introducido sea un número.
                    ancho = alto; //Igualamos el ancho al alto.
                }
                while (!isANumber || alto < 0); //Si el dato no es un número, o es un número negativo, repetimos el bucle.


                for (int i = 0; i < alto; i++) //Se crea el bucle para el salto de línea que se ejecutará después de que cada fila se complete.
                {
                    for (int j = 0; j < ancho; j++) //Se escriben tantos asteriscos como ancho hay en la fila.
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); //Saltamos de línea.
                    ancho--; //Se resta 1 al ancho.
                }
            }
            catch (Exception error) //Nombramos la variable de la excepción.
            {
                Console.Write("Error code {0}", error); //En caso de que haya un error, escribimos en consola el código de dicho error.
            }
        }
    }
}
