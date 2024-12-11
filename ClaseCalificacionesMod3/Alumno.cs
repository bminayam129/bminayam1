
namespace ClaseCalificacionesMod3
{
    public class Alumno
    {
        // Propiedades
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public List<int> Calificaciones { get; set; }

        // Constructor
        public Alumno()
        {
            Calificaciones = new List<int>();
        }

        // Método para calcular el promedio
        public double CalcularPromedio()
        {
            if (Calificaciones.Count == 0)
            {
                return 0; // Evita dividir entre cero
            }
            return Calificaciones.Average();
        }

        // Método para mostrar la información del alumno
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Promedio: {CalcularPromedio():F2}");
        }

    }
}
