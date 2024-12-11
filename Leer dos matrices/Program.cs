namespace Leer_dos_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                // Leer la primera matriz desde la consola
                Console.WriteLine("Ingrese los elementos de la primera matriz, separados por espacios:");
                string[] entrada1 = Console.ReadLine().Split(' ');
                int[] matriz1 = Array.ConvertAll(entrada1, int.Parse);

                // Leer la segunda matriz desde la consola
                Console.WriteLine("Ingrese los elementos de la segunda matriz, separados por espacios:");
                string[] entrada2 = Console.ReadLine().Split(' ');
                int[] matriz2 = Array.ConvertAll(entrada2, int.Parse);

                // Verificar si las matrices son iguales
                bool sonIguales = VerificarIgualdad(matriz1, matriz2);

                // Mostrar el resultado
                if (sonIguales)
                {
                    Console.WriteLine("Las dos matrices son iguales.");
                }
                else
                {
                    Console.WriteLine("Las dos matrices no son iguales.");
                }


                // Método para verificar si dos matrices son iguales
                static bool VerificarIgualdad(int[] matriz1, int[] matriz2)
                {
                    // Verificar si las longitudes son diferentes
                    if (matriz1.Length != matriz2.Length)
                    {
                        return false;
                    }

                    // Comparar los elementos uno por uno
                    for (int i = 0; i < matriz1.Length; i++)
                    {
                        if (matriz1[i] != matriz2[i])
                        {
                            return false; // Retornar falso si hay elementos diferentes
                        }
                    }

                    return true; // Si no hay diferencias, son iguales
                }
            }
            catch ( Exception ex)
            {
                Console.WriteLine("Ocurrió un error inesperado.");
                Console.WriteLine($"Detalles del error: {ex.Message}");

            }    


        }
    }


}
