using System;

namespace calculadora_sueldos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            float totalFact, sueldoTotal;
            const float sueldoFijo = 15000;
            const float porcentajeComision = 0.05F;
            //Ingresar total facturado por el empleado
            Console.WriteLine("Ingrese el monto total facturado en pesos:");
            totalFact = float.Parse(Console.ReadLine());
            //Calcular sueldo total deducido del 5% de lo facturado mas 15000 pesos
            sueldoTotal = sueldoFijo + (totalFact * porcentajeComision);
            //Mostrar sueldo total a pagar en pantalla
            Console.WriteLine("El sueldo total a pagar en pesos es: " + "ARS" + sueldoTotal);
        }
    }
}
