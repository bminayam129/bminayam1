using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class PruebaCuenta
    {
        public static void Main (string[] args)
        {
            Cuenta cuenta1 = new Cuenta(50.00M);
            Cuenta cuenta2 = new Cuenta(-7.53M);

            //Muestra el saldo inicial de cada objeto usando una propiedad
            Console.WriteLine("Saldo de cuenta1: {0:C}", 
                cuenta1.Saldo);

            Console.WriteLine("Saldo de cuenta2: {0:C}\n ", cuenta2.Saldo);

            decimal montoDeposito;

            Console.Write("Escriba el monto a depositar para la cuenta1:");
            montoDeposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("se sumo {0:C} al saldo de cuenta1\n" ,montoDeposito);
            cuenta1.Acredita(montoDeposito);

            //muestra los saldos 
            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta2: {0:C}\n", cuenta2.Saldo);

            //pide y obtiene la entrada del usuario
            Console.Write("Escriba la cantidad a deposiatr para la cuenta2:");
            montoDeposito = Convert.ToDecimal (Console.ReadLine()); 
            Console.WriteLine("Se sumo {0:C} al saldo de cuenta2\n" , montoDeposito);
            cuenta2.Acredita (montoDeposito);

            //muestra los saldos
            Console.WriteLine ("Saldo de cuenta1: {0:C}", cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta2: {0:C}", cuenta2.Saldo);
        }//fin main
    }//Fin de la clase
}
