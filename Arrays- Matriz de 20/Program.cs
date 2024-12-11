namespace Arrays__Matriz_de_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un arreglo de 20 elementos 

            int[] matriz = new int[20];

            //Inicializar cada elemeno con el indice multiplicado por 5

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = i * 5;
            }

            //Imprimir los elementos en la consola

            Console.WriteLine("Elementos de la mariz:");
            for (int i = 0;i < matriz.Length; i++)
            {
                Console.WriteLine($"Elemento [{i}] = {matriz[i]}");
            }
        }
    }
}
