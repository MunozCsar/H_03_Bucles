using System;

namespace H_03_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho, alto; //Creamos las variables del ancho y el alto del rectángulo.
            bool isANumber; //Creamos la variable que comprabará que hayamos introducido un número.

            try //Iniciamos la función try/catch para detectar cualquier error que pueda suceder en el programa.
            {      
                do //Iniciamos un bucle 'do...while'
                {
                    Console.Write("Introduzca un alto: ");  //Pedimos al usuario que introduzca el alto.
                    isANumber = Int32.TryParse(Console.ReadLine(), out alto); //Comprobamos que el dato introducido sea un número.
                    ancho = alto; //Al pedirnos un cuadrado, ancho será igual al alto.
                }
                while (!isANumber || alto < 0 || alto > 9); //Si el dato no es un número, o es un número negativo, o es mayor que 9, repetimos el bucle.

                for (int i = 1; i <= alto; i++) //Creamos el bucle 'for' que contendrá nuestro código.
                {
                    for (int j = 1; j <= ancho; j++) //Escribimos el valor actual de 'i' en la línea.
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine(); //Salto de línea.
                }
            }
            catch (Exception error) //Nombramos la variable de la excepción.
            {
                Console.Write("Error code {0}", error); //En caso de que haya un error, escribimos en consola el código de dicho error.
            }
        }
    }
}
