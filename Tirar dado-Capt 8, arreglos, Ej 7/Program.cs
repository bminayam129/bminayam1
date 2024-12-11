namespace Tirar_dado_Capt_8__arreglos__Ej_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numerosAleatorios = new Random();//generador de numeros aleatorios
            int[] frecuencia = new int[7];// arreglo de contadores de frecuencia 

            //tira el dado 6000 veces; usa el valor del dado como subindice de frecuencia

            for (int tiro = 1; tiro <= 6000; tiro++ )
                ++frecuencia[numerosAleatorios.Next (1 , 7)];

            Console.WriteLine("{0}{1,10}","Cara" ,  "Frecuencia");

            //imprime en pantalla el valor de cada elemento del arreglo

            for (int cara  = 1; cara < frecuencia.Length; cara++ )
                Console.WriteLine("{0,4}{1,10}", cara , frecuencia [cara] );
        }
    }
}
