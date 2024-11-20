using System;

namespace H_03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int cambio, pago, precio; //Creamos las variables correspondientes al cambio, pago y precio del producto.
            bool isANumber; //Creamos la variable que comprabará que hayamos introducido un número.

            try //Iniciamos la función try/catch para detectar cualquier error que pueda suceder en el programa.
            {
                do //Iniciamos un bucle 'do...while'
                {
                    Console.Write("Introduzca el precio del producto: "); //Pedimos al usuario que introduzca el precio del producto.
                    isANumber = Int32.TryParse(Console.ReadLine(), out precio); //Comprobamos que el dato introducido sea un número.
                }
                while (!isANumber || precio < 0); //Si el dato no es un número, o es un número negativo, repetimos el bucle.
                do //Iniciamos un bucle 'do...while'
                {
                    Console.Write("Introduzca el pago: "); //Pedimos al usuario que introduzca el pago.
                    isANumber = Int32.TryParse(Console.ReadLine(), out pago); //Comprobamos que el dato introducido sea un número.
                }
                while (!isANumber || pago < 0); //Si el dato no es un número, o es un número negativo, repetimos el bucle.

                cambio = pago - precio; //Damos el valor de cambio.

                for (int i = 100; i <= cambio; cambio -= i) //Mientras cambio sea mayor o igual al billete, le restaremos su valor.
                {
                    Console.Write("100 "); //Escribimos el valor del billete que nos devuelven.
                }
                for (int i = 50; i <= cambio; cambio -= i) //Mientras cambio sea mayor o igual al billete, le restaremos su valor.
                {
                    Console.Write("50 "); //Escribimos el valor del billete que nos devuelven.
                }
                for (int i = 20; i <= cambio; cambio -= i) //Mientras cambio sea mayor o igual al billete, le restaremos su valor.
                {
                    Console.Write("20 "); //Escribimos el valor del billete que nos devuelven.
                }
                for (int i = 10; i <= cambio; cambio -= i) //Mientras cambio sea mayor o igual al billete, le restaremos su valor.
                {
                    Console.Write("10 "); //Escribimos el valor del billete que nos devuelven.
                }
                for (int i = 5; i <= cambio; cambio -= i) //Mientras cambio sea mayor o igual al billete, le restaremos su valor.
                {
                    Console.Write("5 "); //Escribimos el valor del billete que nos devuelven.
                }
                for (int i = 2; i <= cambio; cambio -= i) //Mientras cambio sea mayor o igual al billete, le restaremos su valor.
                {
                    Console.Write("2 "); //Escribimos el valor del billete que nos devuelven.
                }
                for (int i = 1; i <= cambio; cambio -= i) //Mientras cambio sea mayor o igual al billete, le restaremos su valor.
                {
                    Console.Write("1 "); //Escribimos el valor del billete que nos devuelven.
                }
            }
            catch (Exception error) //Nombramos la variable de la excepción.
            {
                Console.Write("Error code {0}", error); //En caso de que haya un error, escribimos en consola el código de dicho error.
            }
        }
    }
}
