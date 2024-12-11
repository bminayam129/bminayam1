namespace Diezcalificacioness_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int estudiantes = 10; // Número de estudiantes
            int contador = 0; // Contador para las calificaciones
            int aprobados = 0; // Cantidad de estudiantes con calificación >= 7
            int reprobados = 0; // Cantidad de estudiantes con calificación < 7

            // Mensaje inicial

            Console.WriteLine("Por favor, ingrese las calificaciones de 10 estudiantes:");

            while (contador < estudiantes)
            {
                Console.Write($"Ingrese la calificación del estudiante {contador + 1}: ");

                // Leer y validar la entrada
                if (double.TryParse(Console.ReadLine(), out double calificacion) && calificacion >= 0 && calificacion <= 10)
                {
                    if (calificacion >= 7)
                    {
                        aprobados++;
                    }
                    else
                    {
                        reprobados++;
                    }

                    contador++; // Avanzar al siguiente estudiante
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese una calificación válida entre 0 y 10.");
                }
            }

            // Resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Estudiantes aprobados: {aprobados}");
            Console.WriteLine($"Estudiantes reprobados: {reprobados}");
        }
    }
    
}   
