namespace CalcualPromedio100
{
    public class Class1
    {
        public void CalcularCantidadPiezas()
        {
            int index = 1;
            int suma = 0;
            int cantidad = 0;

            int longitud = 0;
            string value = string.Empty;

            try
            {
                Console.WriteLine("Ingrese la cantiadad de piezas a procesar");
                value = Console.ReadLine();

                if (!int.TryParse(value, out cantidad))
                {
                    Console.WriteLine("La Cantidad de piezas a procesar es requerida");
                    return;
                }
                while (index <= cantidad)
                {
                    Console.WriteLine($"Ingrese el valor: { index }");
                    value = Console.ReadLine();

                    Console.WriteLine("Ingrese la longitud de cada pieza a procesar");
                    value = Console.ReadLine();

                    if (longitud >= 1.20 && longitud <= 1.30)
                        cantidad++;
                   

                }
                cantidad++;


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calculando el promedio. {ex.Message}");

            }

        }
    }
}
