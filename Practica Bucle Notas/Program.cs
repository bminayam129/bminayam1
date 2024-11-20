using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Practica_Bucle_Notas
{
    internal class nota
    {
        static void Main(string[] args)
        {
            int aprobados = 0;
            int reprobados = 0;
            double promedio = 0;
            string valor = string.Empty;
            int Nota = 0;
            int CantidadNotas = 0;
            int sumaNotas = 0;


            Console.WriteLine("Cuantas notas agregar?");
            valor = Console.ReadLine();


            if (!int.TryParse(Console.ReadLine(), out CantidadNotas) || CantidadNotas <= 0)
            {
                try
                {

                    for (int i = 1; i <= CantidadNotas; i++)
                    {
                        Console.WriteLine($"Ingrese la nota: {i}");
                        valor = Console.ReadLine();

                        if (int.TryParse(valor, out Nota))
                        {
                            if (Nota >= 7)
                            {

                                aprobados++;
                                //aprobado = aprobado +1;

                            }
                            else
                            {

                                reprobados++;
                                //reprobados = Reprobado +1;

                            }
                            sumaNotas += Nota;


                        }


                        else
                        {

                            Console.WriteLine("El valor ingresado es invalido.");
                            i--;


                        }

                    }

                    promedio = (double)sumaNotas / CantidadNotas;

                    //Imprimir cantidad de aprobados y reprobados

                    Console.WriteLine($"La cantidad de aprobados es : {aprobados} y la cantidad de reprobados es: {reprobados}");
                    Console.WriteLine($"El promedio de las notas es: {promedio}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error calculando las notas. {ex.Message}");
                }


            }

        }

    }
}