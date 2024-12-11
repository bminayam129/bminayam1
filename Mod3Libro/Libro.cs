

namespace Mod3Libro
{
    internal class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Pagina { get; set; }

  
        public void MostrarInformacion()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"pagina: {Pagina}");
        }
        public bool EsLargo()
        {
            return Pagina > 500;
        }
    }


}
