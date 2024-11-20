internal class Program
{
    private static void Main(string[] args)
    {
        //Declaracion de Variables
        int lado = 0;
        int r = 4;
        int perimetro = 0;  

        //Pedir datos
        Console.WriteLine("Digite la longitud del lado del cuadrado");
        lado = Convert.ToInt32(Console.ReadLine());


        perimetro = r * lado;

        Console.WriteLine($"El tamaño del perimetro es: {perimetro}");
        


    }
}