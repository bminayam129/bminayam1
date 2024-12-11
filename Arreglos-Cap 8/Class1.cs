namespace Arreglos_Cap_8
{
    public class InicArreglo
    {
        public static void Main(string[] args)
        {
            int[] arreglo; //Declarar variable llamada arreglo

            //Crear el espcio paa el arrelo y lo inicializa con ceros predeterminados

            arreglo = new int [10]; //10 Elementos int 


            Console.WriteLine("{0}{1,8}", "Indice", "Valor");// Encabezados

            for (int contador = 0; contador < arreglo.Length; contador++) 
                Console.WriteLine ( "{0,5}{1,8}" , contador, arreglo[contador]);



        }

    }
}
