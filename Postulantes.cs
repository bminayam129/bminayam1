using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declarar variables

        int Totalpreguntas = 0;
        int respuestascorrectas = 0;
        double porcentaje = 0;
        int aprobados = 0;
        int Reprobados = 0;
        int CantidadNota = 0; 
        string valor = string.Empty;
        

        //Introducir datos 

        Console.WriteLine($"Ingrese la cantidad de preguntas");
        Totalpreguntas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Ingrese total de respuestas correctas");
        respuestascorrectas = Convert.ToInt32(Console.ReadLine());

        // Condicional para evitar que se agregue un dato falso 

        if (respuestascorrectas > Totalpreguntas)
        {
            Console.WriteLine($"La cantidad de respuestas correctas no puede ser mayor a la cantidad total de preguntas, favor ingresar los datos correctamente");

        }
        //Calculo de porcentaje

        else
        {
            porcentaje = (double)respuestascorrectas / Totalpreguntas * 100;
            Console.WriteLine($"El porcentaje final es: {porcentaje:F2}%");
        }

        //Condicionales 

        if (porcentaje >= 90)
        {
            Console.WriteLine($"Nivel Maximo");
            return;
        }

        if (porcentaje >= 75 && porcentaje < 90)
        {
            Console.WriteLine($"Nivel Medio");
            return;


        }

        if (porcentaje >= 50 && porcentaje < 75)
        {
            Console.WriteLine($"Nivel regular");
            return;
        }

        if (porcentaje < 50)
        {
            Console.WriteLine($"Fuera de nivel");
            return; 
        }

            }
    
}

