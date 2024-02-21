using System;

namespace calculadora_tiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir variables
            float km, v, tiempo;
            //Solicitar numeros
            Console.WriteLine("Ingrese la distancia en KM:");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad en KM/H:");
            v = float.Parse(Console.ReadLine());
            //Calcular usando la ecuacion de tiempo
            tiempo = km / v;
            //Mostrar resultado en pantalla
            Console.WriteLine("Tiempo de viaje estimado: " + tiempo.ToString("0.00") + " horas.");
        }
    }
}
