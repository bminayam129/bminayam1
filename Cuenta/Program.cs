namespace Cuenta
{
    public class Cuenta
    {
        private decimal saldo; 
        //Constructor
        public Cuenta(decimal saldoInicial) 
        {
            Saldo=saldoInicial;

        }//fin constructor de cuenta

        //acredita (suma) un monto a la cuenta 
        public void Acredita (decimal monto)
        {
            Saldo = Saldo + monto;
        }

        public decimal Saldo
        {
            get {

                return saldo; 
            }
            set
            {
                if (value >= 0)
                    saldo = value; 
            }

        }
    }
}
