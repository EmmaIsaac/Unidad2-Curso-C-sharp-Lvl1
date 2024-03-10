using System;

namespace calculadora_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir variables variables
            int n1, resultado;

            //Pedir numero
            Console.WriteLine("Ingrese un número:");
            n1 = int.Parse(Console.ReadLine());

            //Realizar calculo
            resultado = n1 * n1 * n1;

            //Mostrar resultado
            Console.WriteLine("El resultado de elevar " + n1 + " al cubo es: " + resultado);

        }
    }
}
