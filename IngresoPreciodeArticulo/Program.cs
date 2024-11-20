internal class Program
{
    private static void Main(string[] args)
    {
        //Declaracion de Variables 
        int precio = 0;
        int articulos = 0;
        int producto = 0;

        //Proveer informaciones

        Console.WriteLine("Cual es el precio del articulo?");
        precio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite cantidad de articulos: ");
        articulos = Convert.ToInt32(Console.ReadLine());

        //Calculo de abono del comprador

        producto = ( precio * articulos );

        //Imprimir resultados 

        Console.WriteLine($"El total a abonar es: {producto} ");




    }
}