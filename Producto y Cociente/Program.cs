internal class Program
{
    private static void MainProductoyconciente(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        int suma = 0;
        int resta = 0;
        int producto = 0;
        int cociente = 0;

        Console.WriteLine("Ingrese el primer numero:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            suma = (num1 + num2);
            resta = (num1 - num2);

            Console.WriteLine("El primer numero es mayor");


            Console.WriteLine($"El resultado de la suma es: {suma}");
            Console.WriteLine($"El resultado de la resta es: {resta}");

            return;

        }
        else
        { 
            producto = (num1 * num2);
            cociente = (num1 / num2);

            Console.WriteLine("El segundo numero es mayor");


            Console.WriteLine($"El resultado de la multiplicaion es: {producto}");
            Console.WriteLine($"El resultado de la division es: {cociente}");

            return;
        }
    }

}
