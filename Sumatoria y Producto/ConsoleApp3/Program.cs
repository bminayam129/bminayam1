using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declaracion de variables 

        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int suma = 0;
        int Producto = 0;

        // Datos a introducir 

        Console.WriteLine("Escriba el valor del primer numero");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba el valor del segundo numero");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba el valor del tercer numero");
        num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba el valor del cuarto numero");
        num4 = Convert.ToInt32(Console.ReadLine());

        //Ejecucion de las expresiones 

        suma = (num1 + num2);
        Producto = (num3 * num4);

        Console.WriteLine($"La suma de los dos primeros numeros es: { suma } y el producto de los dos ultimos numeros es: {Producto}");


    }
}