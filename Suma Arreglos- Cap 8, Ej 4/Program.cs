namespace Suma_Arreglos__Cap_8__Ej_4
{
    internal class SumaArreglos
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            for (int contador = 0; contador < arreglo.Length; contador++) 
                total += arreglo[contador];

            Console.WriteLine("Total de los elementos de arreglo: {0}" , total);
        }
    }
}
