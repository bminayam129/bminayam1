namespace Mod3Libro
{
    class Program
    {
        static void Main(string[] args)
        {

            string value = string.Empty;

            try
            {

                Console.WriteLine("Ingrese la informacion del libro");

                Console.WriteLine("Titulo: ");
                string titulo = Console.ReadLine();

                Console.WriteLine("Autor:");
                string autor = Console.ReadLine();

                Console.WriteLine("Cantidad de Paginas");
                int paginas;

                while (!int.TryParse(Console.ReadLine(), out paginas) || paginas < 0)
                {
                    Console.WriteLine("Por favor, introduzca un numero valido para las paginas:");
                }

                //Mostrar informacion de primer libro y comprobar si es largo

                Libro libro = new Libro
                {

                    Titulo = titulo,
                    Autor = autor,
                    Pagina = paginas

                };

                Console.WriteLine("\nInformacion del libro:");
                libro.MostrarInformacion();
                Console.WriteLine($"Es Largo? {libro.EsLargo()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error {ex.Message}");


            }
        }
    }
}
