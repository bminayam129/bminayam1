namespace Cap_8__arreglos___Ej_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int LONGITUD_ARREGLO = 10; //CREA UNA CONSTANTE CON NOMBRE 
            int[] arreglo= new int[LONGITUD_ARREGLO];

            for (int contador = 0; contador < arreglo.Length; contador++)
                arreglo [contador] = 2+2 * contador;

            Console.WriteLine("{0}{1,8}", "Indice", "Valor"); 

            for (int contador = 0;contador < arreglo.Length;contador++)
                Console.WriteLine("{0,5}{1,8}", contador, arreglo [contador]);
        }
    }
}
