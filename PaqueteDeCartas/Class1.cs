namespace PaqueteDeCartas
{
    public class PaquetedeCartas
    {
        private cartas[] paquete;
        private int cartaActual;
        private const int NUMERO_DE_CARTAS = 52 ;
        private Random numerosAleatorios; 


        public PaquetedeCartas()
        {
            string[] caras = { "As", "Dos", "Tres", "Cuatro", "Cinco", " Seis", " Siete", "Ocho", "Nueve", "Diez", "Joto", "Quina", "Rey" };
            string[] palos = { "Corazones", "Diamantes", "Treboles", "Espadas" };

            paquete = new carta[NUMERO_DE_CARTAS];
            cartaActual = 0;

            numerosAleatorios = new Random();

            for (int cuenta = 0; cuenta < paquete.Length; cuenta++)
                paquete[cuenta] =
                    new cartas(caras[cuenta % 13], palos[cuenta / 13]);



        }

    } 
}
