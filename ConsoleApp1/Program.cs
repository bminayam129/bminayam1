internal class Program
{
    private static void Main (string[] args)
    {
        decimal sueldo = 0;
        string? valor = string.Empty;
        decimal itbis = 0.18m;
        decimal impuesto = 0;
        decimal TotalAPagar = 0;


        Console.WriteLine($"Digite el sueldo neto del empleado");
        valor= Console.ReadLine();

         // Validacion de los input

        if ( string.IsNullOrEmpty(valor) )
        {
            Console.WriteLine($"El sueldo no puede ser nulo.");
            return;
            
        }
        if (valor.Length > 40)
        {


        }

        if (!decimal.TryParse( valor, out sueldo) )
        {
            Console.WriteLine($"El sueldo {valor} ingresado no es valido.");
            return;
        }
        //Condicionales 

        if (sueldo < 0)
        {
            Console.WriteLine("El sueldo no puede ser negativo");
        }
        if (sueldo > 32000)
        {

            impuesto = (sueldo * itbis);
            TotalAPagar = (sueldo - impuesto);

            Console.WriteLine($"Impuesto: { impuesto } y sueldo despues de impuesto: { TotalAPagar }");

          

        }
        else
        {
            Console.WriteLine("No debe de pagar impuestos");
        }
    }

    private static void MayorDeDosNumeros()
    {
        int num1 = 0;
        int num2 = 0;
        String Valor = String.Empty;

        //Pedir numeros por teclado

        Console.WriteLine("Escriba el valor del primer numero:");
        Valor = Console.ReadLine();

        if (string.IsNullOrEmpty(Valor))
        {
            Console.WriteLine("Se requiere el primer numero");
        }

        if (int.TryParse(Valor, out num1))
        {

        }
    }
