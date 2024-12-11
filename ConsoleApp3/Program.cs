namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 0;


                // Solicitud de numeros

                Console.WriteLine("Cuantos numeros desea ingresar?");


                // Validar entrada para cantidad
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido mayor a 0:");
                }

                //arreglo para almacenar numeros 
                int[] numeros = new int[n];



                // Solicitud de numeros al usuario

                Console.WriteLine($"Digite los {n} nuneros que desea ingresar:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                    {
                        Console.WriteLine("La entrada no es valida, por favor ingresar un numero entero");
                    }


                    //Determinar el valor menor, indicar si se repiten al menos una vez 



                }

                int menor = numeros[0];

                //Determinar el valor menor, indicar si se repiten al menos una vez 

                HashSet<int> valoresUnicos = new HashSet<int>();
                bool hayDuplicados = false;

                foreach (int numero in numeros)
                {

                    if (numero < menor) menor = numero;

                    //verificar si hay duplicados

                    if (!valoresUnicos.Add(numero))
                    {
                        hayDuplicados |= true;
                    }


                    
                }

                Console.WriteLine("\nResultados:");
                Console.WriteLine($"Número menor: {menor}");
                Console.WriteLine(hayDuplicados
                ? "Al menos un valor se repite."
                : "No hay valores repetidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado.");
                Console.WriteLine($"Detalles del error: {ex.Message}");

            }

        }
    }
}
