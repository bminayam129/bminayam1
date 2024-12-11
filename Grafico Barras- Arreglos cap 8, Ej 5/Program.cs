namespace Grafico_Barras__Arreglos_cap_8__Ej_5
{
    internal class GraficoBarras
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };

            Console.WriteLine("Distribucion de las calificaciones:");

            //para cada elemento del arreglo, mostrar en pantalla una barra de grafico

            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                //Muestra etiqueta de las barras 
                if (contador == 10)
                    Console.Write(" 100: ");

                else
                    Console.Write("{0:D2} - {1:D2}:",
                        contador * 10, contador * 10 + 9);

                for (int estrellas = 0; estrellas < arreglo[contador]; estrellas++)
                    Console.Write("*");

                Console.WriteLine();// Inicia una nueva linea de salida
            }
        }
    }
}
