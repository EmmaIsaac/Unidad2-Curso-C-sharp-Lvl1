using System;

namespace calculadora_promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            float n1, n2, n3, promedio;
            //Solicitar notas del alumno
            Console.WriteLine("Ingrese la primer nota:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");
            n3 = float.Parse(Console.ReadLine());
            //Calcular nota promedio
            promedio = (n1 + n2 + n3) / 3;
            //Mostrar nota promedio en pantalla
            Console.WriteLine("La nota promedio es: " + promedio.ToString("0.00")); 
        }
    }
}
