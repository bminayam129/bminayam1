namespace TrianguloSuperiora12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string value = string.Empty;
          

            try
            {
                Console.WriteLine("A cuantos triangulos le gustaria calcular las dimensiones?");
                int n = int.Parse(Console.ReadLine());

                double limite = 12;
                int contador = 0;
                double[] bases = new double[n];
                double[] alturas = new double[n];
                double[] areas = new double[n];

                if (n <= 0)
                {
                    Console.WriteLine("El numero de triangulos debe ser mayor que cero.");
                    return;


                }

                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine($"Ingrese la base del triangulo {i + 1}:");


                    while (!double.TryParse(Console.ReadLine(), out bases[i]) || bases[i] <= 0)
                    {
                        Console.WriteLine("Por favor, ingrese un valor válido para la base(mayor o igual a cero:");
                    }

                    Console.WriteLine($"Ingrese la altura del triangulo {i + 1}:");


                    while (!double.TryParse(Console.ReadLine(), out alturas[i]) || alturas[i] <= 0)
                    {
                        Console.WriteLine("Por favor, ingrese un valor válido para la altura(mayor o igual a cero:");
                    }

                    //calcular area y almacenar 

                    areas[i] = (bases[i] * alturas[i]) / 2;

                    if (areas[i] > limite)
                    {
                        contador++;


                    }

                }



                //Mostrar resultado 

                Console.WriteLine($"Numero de triangulos cuyos exceden el valor limite: {contador}");

                Console.WriteLine("\nDatos de los triangulos ingresados:");

                for (int i = 0; i < n; ++i)
                {
                    Console.WriteLine($" Triangulo {i + 1}:");
                    Console.WriteLine($" Base: {bases[i]}");
                    Console.WriteLine($"  Altura: {alturas[i]}");
                    Console.WriteLine($"  Área: {areas[i]}");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($" Error calculado las dimensiones del triangulo {ex.Message}");
            }


        }
    }
}

