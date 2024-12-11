﻿using System.Xml;

namespace Cap_8_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo; //Declarar variable llamada arreglo

            //Crear el espcio paa el arrelo y lo inicializa con ceros predeterminados

            arreglo = new int[10]; //10 Elementos int 


            Console.WriteLine("{0}{1,8}", "Indice", "Valor");// Encabezados

            // Imprime en pantalla el valor de cada elemento del arreglo 

            for (int contador = 0; contador < arreglo.Length; contador++)
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);

        }
    }

   
    
}
