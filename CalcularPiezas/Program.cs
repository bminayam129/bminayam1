 

namespace CalcularPiezas
{

    internal class Piezas
    {
        static void Main(string[] args)
        {

            int index = 0;
            int piezasaptas = 0;
            int piezasnoaptas = 0;
            int cantidad = 0;
            string value = string.Empty;
            float longitud = 0;



            try
            {
                Console.WriteLine("Ingrese la cantidad de piezas a procesar");
                cantidad = int.Parse(Console.ReadLine());

                float[] longitudes = new float[cantidad];

                while (index < cantidad)
                {

                    Console.WriteLine($"Ingrese la longitud de las piezas {index + 1}:");
                    value = Console.ReadLine();

                    //Validacion de los datos

                    if (!float.TryParse(value, out longitud))
                    {

                        Console.WriteLine("El valor de la longitud no es valido.");
                        continue;
                    }

                    longitudes[index] = longitud;


                    if (longitud >= 1.20 && longitud <= 1.30)
                    {

                        piezasaptas++;

                    }

                    else

                    {

                        piezasnoaptas++;


                    }
                    // Verificar si la pieza es apta




                    index++; // Incrementar Indice 



                }

                //Mostrar resultados

                Console.WriteLine($"La cantidad de piezas aptas es: {piezasaptas}");
                Console.WriteLine($"La cantidad de piezas no aptas es: {piezasnoaptas}");

                Console.WriteLine("\nLongitudes ingresadas:");
                index = 0; // Reiniciar el índice para mostrar todas las piezas
                while (index < longitudes.Length)
                {

                    Console.WriteLine($"Pieza {index + 1}: {longitudes[index]}");
                    index++;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calculando el promedio. {ex.Message}");

            }

        }
    }
}
