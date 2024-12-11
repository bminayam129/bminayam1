namespace ClaseCalificacionesMod3
{
    internal class Program
    {
        class Programa
        {
            static void Main(string[] args)
            {
                // Crear una instancia de la clase Alumno
                Alumno alumno = new Alumno();

                // Solicitar información del alumno al usuario
                Console.Write("Ingrese el nombre del alumno: ");
                alumno.Nombre = Console.ReadLine();

                Console.Write("Ingrese la matrícula del alumno: ");
                alumno.Matricula = Console.ReadLine();

                Console.Write("Ingrese la carrera del alumno: ");
                alumno.Carrera = Console.ReadLine();

                Console.WriteLine("Ingrese las calificaciones del alumno (escriba 'fin' para terminar):");

                while (true)
                {
                    Console.Write("Calificación: ");
                    string entrada = Console.ReadLine();

                    if (entrada.ToLower() == "fin")
                        break;

                    if (int.TryParse(entrada, out int calificacion) && calificacion >= 0 && calificacion <= 100)
                    {
                        alumno.Calificaciones.Add(calificacion);
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese una calificación válida (0-100).");
                    }
                }

                // Mostrar la información del alumno
                Console.WriteLine("\nInformación del alumno:");
                alumno.MostrarInformacion();
            }
        }
    }
}
