namespace BucleForDivisiblesPor3o5
{
    internal class Divisibles
    {
        static void Main(string[] args)
        {
            int contador = 0;
            

            int[] num = new int [10];


            try
            {

                Console.WriteLine("Por favor ingresar numeros a evaluar");

                for (int i = 0; i < num.Length; i++)
                {

                    Console.WriteLine($"Ingrese numeros {i + 1}");
                    

                    while (!int.TryParse(Console.ReadLine(), out num[i]))
                    {
                        Console.WriteLine("Por favor, ingrese un numero valido");
                        Console.WriteLine($"Ingrese el numero {i + 1}");

                    }


                }




                foreach (int numero in num)
                {
                    if (numero % 3 == 0 || numero % 5 == 0)
                    {
                        contador++;
                    }


                }

                Console.WriteLine($"Los numeros que son divisibles por 3 o 5 son: {contador} ");



            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error calculando divisibles {ex.Message} ");

            }


        }
    }
}
