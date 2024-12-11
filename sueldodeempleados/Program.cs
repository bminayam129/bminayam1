namespace sueldodeempleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int empleados;
                int contador = 0; // Contador para los salarios
                int grupo1 = 0; // Empleados con salario entre $100 y $300
                int grupo2 = 0; // Empleados con salario mayor a $300
                double gastoTotal = 0; // Gasto total en nómina

                Console.WriteLine("Ingrese el número total de empleados:");
                if (!int.TryParse(Console.ReadLine(), out empleados) || empleados <= 0)
                {
                    Console.WriteLine("Por favor, ingrese un número válido de empleados (mayor a 0).");
                    return;
                }

                double[] salarios = new double[empleados]; // Arreglo para almacenar los salarios

                while (contador < empleados)
                {
                    Console.Write($"Ingrese el salario del empleado {contador + 1} (entre $100 y $500): ");

                    // Leer y validar el salario
                    if (double.TryParse(Console.ReadLine(), out double salario) && salario >= 100 && salario <= 500)
                    {
                        salarios[contador] = salario; // Almacenar salario en el arreglo
                        gastoTotal += salario; // Sumar al gasto total

                        // Clasificar el salario en uno de los dos grupos
                        if (salario <= 300)
                        {
                            grupo1++;
                        }
                        else
                        {
                            grupo2++;
                        }

                        contador++; // Avanzar al siguiente empleado
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un salario válido (entre $100 y $500).");
                    }
                }

                // Mostrar los resultados
                Console.WriteLine("\nResultados:");
                Console.WriteLine($"Número de empleados con salario entre $100 y $300: {grupo1}");
                Console.WriteLine($"Número de empleados con salario mayor a $300: {grupo2}");
                Console.WriteLine($"Gasto total en nómina: ${gastoTotal:F2}");
            }
        }
    }
}
