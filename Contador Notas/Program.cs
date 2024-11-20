using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace Contador_Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variables

            double promedio = 0;
            int CantidadNotas = 0;
            string valor = string.Empty;
            int valoringresado = 0;
            int suma = 0;
            int aprobados = 0;
            int Regular = 0;
            int Reprobado = 0;


            //Pedir valores 

            Console.WriteLine("Escriba la cantidad de notas a calcular: ");
            CantidadNotas = Convert.ToInt32(Console.ReadLine());

            try
            {


                if (int.TryParse(valor, out CantidadNotas))
                    for (int i = 1; i <= CantidadNotas; i++)
                    {

                        Console.WriteLine($"Ingrese la nota: {i}");
                        valor = Console.ReadLine();

                        //Calcular promedio

                        promedio = (suma / CantidadNotas);

                        Console.WriteLine($"La suma es: {suma} y el promedio es {promedio}");

                        if (int.TryParse(valor, out valoringresado))
                        {

                            suma = suma + valoringresado;

                            {

                                if (CantidadNotas >= 7)
                                {
                                    aprobados++;
                                    
                          
                                }

                                else
                                {
                                    Reprobado++;
                                    
                                }
                                Console.WriteLine($"La cantidad de aprobados es: {aprobados} y de reprobados es {Reprobado}");

                            }

                        else
                        {
                            Console.WriteLine("El valor ingresado es invalido");





                        }




                        

                    }


            catch (Exception ex)
                    {

                Console.WriteLine($"Error calculando las notas.  {ex.Message}");


            
            }

        }
           
    }

}
