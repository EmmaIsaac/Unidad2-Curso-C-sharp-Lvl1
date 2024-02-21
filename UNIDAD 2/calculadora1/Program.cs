using System;

namespace calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int n1, n2, resultado;

            //Pedir Valores
            Console.WriteLine("Ingrese un número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro:");
            n2 = int.Parse(Console.ReadLine());

            //Realizar calculo
            resultado = n1 + n2;

            //Emitir resultado
            Console.WriteLine("La suma es: " + resultado);
        }
    }
}
