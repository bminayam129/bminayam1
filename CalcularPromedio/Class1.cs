using System.Runtime.Intrinsics.X86;

namespace BuclesWhile

{
    public class Calcular()
    {

    }


    public void Calcular()
    {
        int index = 1;
        int suma = 0;
        int n = 0;
        decimal promedio = 0;
        string value = string.Empty;

        try
        {
            Console.WriteLine("Ingrese la cantidad de numeros para el calculo del promedio");
            value = Console.ReadLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error calculando el promedio. {ex.Message}");

        }

    }

    public void Cantidad()


}
