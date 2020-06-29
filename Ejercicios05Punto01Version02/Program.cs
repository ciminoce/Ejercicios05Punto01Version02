using System;

namespace Ejercicios05Punto01Version02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Segundo Ejemplo de Ciclos";
            var suma = 0;
            var contador = 0;
            do
            {
                Console.Write($"Ingrese el número {contador + 1}:");
                var nro = int.Parse(Console.ReadLine());
                suma += nro;
                contador++;
            } while (contador < 10);

            Console.Write($"La suma de {contador} números es {suma}:");


            
		}
    }
}
