using System;

namespace Numeros_Positivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int index = 1;
            string value = string.Empty;

            try
            {
                Console.WriteLine("Ingrese la cantidad de numeros que desea calcular:");
                value = Console.ReadLine();


                if (!int.TryParse(value, out n))
                {
                    Console.WriteLine("La cantidad de numero es requerida");
                    return;

                }
                //Verificar si el numero ingresado es negativo
                if (n < 0)
                {
                    Console.WriteLine("Debe ingresar numeros positivos.");
                    return;

                }
                while (index <= n)
                {
                    Console.WriteLine(index.ToString());
                    index++;

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calculando numero positivo: {ex.Message}");
            }
        }
    }
}
    

