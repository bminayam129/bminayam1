using System;

internal class Program
{
    private static void Main(string[] args)
    {

        //Declarar Variables
        double nota1 = 0;
        double nota2 = 0;
        double nota3 = 0;
        double promedio = 0;

        //Pedir valores 

        Console.WriteLine("Escriba el valor de la primera nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escriba el valor de la segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escriba el valor de la tercera nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());


        //Calcular promedio

        promedio = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"La nota final es: { promedio}");

        //Imprimir Valores
        //

        if (promedio >= 7)
        {

            Console.WriteLine("Promocionado");
            return;
        }
        if (promedio >= 4)
        {
            Console.WriteLine("Regular");
            return;

        }
        else
        {
            Console.WriteLine("Reprobado");
            return;

        }

        //refactoring 



    }
}


