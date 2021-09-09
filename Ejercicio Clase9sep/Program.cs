using System;

namespace Ejercicio_Clase9sep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Title = ("Mayor, Menor y Sumatoria");
            int i, emax, emin;
            Int32 n, max = 0, min = 0, sum = 0;

            Console.WriteLine("Ingrese 4 enteros:");
            for (i = 1; i <= 4; i = i + 1)
            {
            n = Int32.Parse(Console.ReadLine());
            if (i ==1)
            {
            max=n;
            min = n;
            }

            if (n>max)
            {
            max = n;
            }

            if (n<min)
            {
            min = n;
            }

            if (n < 0)
            {
            Console.WriteLine("No puedes ingresar números negativos. :(");
            }
            if (n == 0)
            {
            Console.WriteLine("No puedes ingresar el 0. :(");
            }

            if ((n >= 0) && (n<=200))
            {
            sum = sum + n;
            }
            }

            Console.WriteLine("El numero mayor es: " + max);
            Console.WriteLine("El numero menor es: " + min);

            { 
            if (sum >= 200)
            {
            Console.WriteLine("La suma de los números excede 200.");
            }

            else
            {
            Console.WriteLine("La suma de los números es: " + sum);
            }
            }

            if (min > 10)
            {
            emax = min + 10;
            Console.WriteLine("Ya que el número menor es mayor a 10, el número mayor es: " + emax);
            }
            if (max < 50)
            {
            emin = min - 5;
            Console.WriteLine("Ya que el numero mayor es menor a 50, el número menor es: " + emin);
            }


            Console.ReadKey();
        }
    }
}
