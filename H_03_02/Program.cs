using System;

namespace H_03_02
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
                    Console.Write("Introduzca un ancho: "); //Pedimos al usuario que introduzca el ancho.
                    isANumber = Int32.TryParse(Console.ReadLine(), out ancho); //Comprobamos que el dato introducido sea un número.
                }
                while (!isANumber || ancho < 0); //Si el dato no es un número, o es un número negativo, repetimos el bucle.
                do //Iniciamos un bucle 'do...while'
                {
                    Console.Write("Introduzca un alto: "); //Pedimos al usuario que introduzca el alto.
                    isANumber = Int32.TryParse(Console.ReadLine(), out alto); //Comprobamos que el dato introducido sea un número.
                }
                while (!isANumber || alto < 0); //Si el dato no es un número, o es un número negativo, repetimos el bucle.


                for (int i = 1; i <= alto; i++) //Iniciamos el bucle 'for' que contendrá el código para la creación del rectángulo, se encarga del cambio de línea.
                {
                    if (i == 1 || i == alto) //Comprobamos si el valor de 'i' es 1 o igual al alto del rectángulo.
                    {
                        for (int j = 1; j <= ancho; j++) //Si se cumple la condición del 'if', dibujaremos en consola una línea de asteriscos.
                        {
                            Console.Write("*"); //Carácter a dibujar.
                        }

                    }

                    else //Mientras 'i' no sea ni 1 ni igual al alto, correremos este código.
                    {
                        for (int k = 1; k <= ancho; k++) //Iniciamos el bucle 'for' para dibujar el interior del rectángulo.
                        {
                            if (k == 1 || k == ancho) //Si la posición de 'k' es 1 o igual al ancho, dibujaremos un asterisco.
                            {
                                Console.Write("*"); //Carácter a dibujar.
                            }
                            else //En caso de que la posicion de 'k' no sea ni 1 ni igual al ancho, dibujaremos un espacio, dejando el interior del rectángulo hueco.
                            {
                                Console.Write(" "); //Carácter a dibujar.
                            }
                        }
                    }
                    Console.WriteLine(""); //Salto de línea               
                }
            }
            catch (Exception error) //Nombramos la variable de la excepción.
            {
                Console.Write("Error code {0}", error); //En caso de que haya un error, escribimos en consola el código de dicho error.
            }           
        }
    }
}
