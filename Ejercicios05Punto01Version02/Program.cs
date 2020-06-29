using System;

namespace Ejercicios05Punto01Version02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Segundo Ejemplo de Ciclos";
            var suma = 0;
            var contador = 0;
            int nro;
            do
            {
                Console.Write($"Ingrese el número {contador + 1}:");
                //Ciclo de validación de ingreso de datos
                while (!int.TryParse(Console.ReadLine(),out nro))
                {
                    Console.WriteLine("Trate otra vez con un entero");
                }
                suma += nro;
                contador++;
            } while (contador < 4);
            Console.Write($"La suma de {contador} números es {suma}:");
        }
    }
}
