namespace EncuestaEstudiantil__Cap_8__arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] respuestas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 6, 5, 2, 3, 10, 2, 5, 6, 9, 4, 5, 7, 8, 10 };
            int[] frecuencia = new int[11];

            for (int respuesta = 0; respuesta < respuestas.Length; respuesta++)
                ++frecuencia[respuestas [respuesta]];

            Console.WriteLine(" {0}{1,11}", "Calificacion", "Frecuencia");

            for (int calificacion = 1; calificacion < frecuencia.Length; calificacion++)
                Console.WriteLine("{0,12}{1,11}", calificacion, frecuencia [calificacion]);
        }
    }
}
